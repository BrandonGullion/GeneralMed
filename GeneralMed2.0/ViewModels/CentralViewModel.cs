using GalaSoft.MvvmLight.Command;
using GeneralMed2._0.Commands;
using GeneralMed2._0.Models;
using GeneralMed2._0.Pages;
using GeneralMed2._0.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GeneralMed2._0
{
    public class CentralViewModel : BasePropertyChanged
    {
        #region Properties 

        private Visibility settingVisibility;

        public Visibility SettingVisibility
        {
            get { return settingVisibility; }
            set { settingVisibility = value; OnPropertyChanged(nameof(SettingVisibility)); }
        }


        private List<PatientModel> filteredList;

        public List<PatientModel> FilteredList
        {
            get { return filteredList; }
            set { filteredList = value; OnPropertyChanged(nameof(FilteredList)); }
        }


        private string searchText;

        public string SearchText
        {
            get { return searchText; }
            set { searchText = value; OnPropertyChanged(nameof(SearchText)); SearchPatientCommand.RaiseCanExecuteChanged(); }
        }


        public static string Path = Directory.GetCurrentDirectory(); 

        /// <summary>
        /// Patient List to be displayed on the screen when navigated to 
        /// </summary>
        private List<PatientModel> patientListModel;

        public List<PatientModel> PatientListModel
        {
            get { return patientListModel; }
            set { patientListModel = value; OnPropertyChanged(nameof(PatientListModel)); }
        }

        
        /// <summary>
        /// Selected Patient that will update side controls when it is updated 
        /// </summary>
        private PatientModel selectedPatient;

        public PatientModel SelectedPatient
        {
            get { return selectedPatient; }
            set 
            { 
                selectedPatient = value; 
                OnPropertyChanged(nameof(SelectedPatient)); 
                UpdateSideMenuText(); 
                DeletePatientWindowCommand.RaiseCanExecuteChanged();
                OpenUpdatePatientWindowCommand.RaiseCanExecuteChanged();
                SelectPatientCommand.RaiseCanExecuteChanged();
            }
        }

        private Page currentPage;
        
        public Page CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; OnPropertyChanged(nameof(CurrentPage)); }
        }


        #endregion

        #region Windows

        public DeletePatientWindow DeletePatientWindow { get; set; }

        public UpdatePatientWindow UpdatePatientWindow { get; set; }


        #endregion

        #region Commands

        public RelayCommand SearchPatientCommand { get; set; }

        public InsertPatientCommand InsertPatientCommand { get; set; }

        public RelayCommand DeletePatientWindowCommand { get; set; }

        public  RelayCommand OpenUpdatePatientWindowCommand { get; set; }

        public RelayCommand SelectPatientCommand { get; set; }

        public RelayCommand ToggleSettingVisibilityCommand { get; set; }

        public RelayCommand OpenAddDrugWindowCommand { get; set; }

        public RelayCommand OpenAddGeneralUseCommand { get; set; }

        public RelayCommand HomeCommand { get; set; }
        public RelayCommand BackButtonCommand { get; set; }

        #endregion




        #region Constructor

        public CentralViewModel()
        {
            #region Commands

            // Uses the text present in the search bar to make a query of the list 
            // Can execute based on text present in the search bar
            SearchPatientCommand = new RelayCommand(() => ChangeToSearchPage());

            SelectPatientCommand = new RelayCommand(() => SelectPatient(SelectedPatient), () => CheckSelectedPatient());

            InsertPatientCommand = new InsertPatientCommand();

            DeletePatientWindowCommand = new RelayCommand(() => OpenDeleteWindow(SelectedPatient), () => RequireSelectedPatient(SelectedPatient));

            OpenUpdatePatientWindowCommand = new RelayCommand(() => OpenUpdateWindow(SelectedPatient), () => RequireSelectedPatient(SelectedPatient));

            ToggleSettingVisibilityCommand = new RelayCommand(() => ToggleVisibility());

            OpenAddDrugWindowCommand = new RelayCommand(() => OpenAddDrugWindow());

            OpenAddGeneralUseCommand = new RelayCommand(() => OpenGeneralUseWindowCommand());

            BackButtonCommand = new RelayCommand(() => Return());

            HomeCommand = new RelayCommand(() => ReturnToDashboard());

            #endregion

            // Set The current page on startup
            CurrentPage = new CalendarPage();
            PatientListModel = new List<PatientModel>();

            SettingVisibility = Visibility.Collapsed;

        }

        #endregion

        #region Methods

        public void ReadDB()
        {
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(DatabaseHelper.databasePath))
            {
                connection.CreateTable<PatientModel>();
                PatientListModel = (connection.Table<PatientModel>().ToList()).OrderBy(p => p.FirstName).ToList();
            }
        }

        // <---------------------------> Search Mechanism <---------------------------> 

        public void ChangeToSearchPage()
        {
            // ReadDB to populate the patient list
            ReadDB();

            // Creating new instance of the patient page to prepare it for moving into the frame 
            var page = new PatientSearchPage();

            /// Checking if the Search text is empty, if so return the full list of patients, else return the filtered items 
            if (!string.IsNullOrWhiteSpace(SearchText))
            {
                // Array of non-allowed characters 
                string[] NonAllowedChar = { "/", ".", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+" };

                // Checks for incorrect characters being entered 
                foreach (var symbol in NonAllowedChar)
                    if (searchText.Contains(symbol))
                    {
                        // TODO: Create a small control that will pop up if a non allowed character is entered
                        MessageBox.Show("Non-Allowed Character Entered");
                        return;
                    }

                // Check for seperator 
                if (searchText.Contains(","))
                {
                    List<PatientModel> firstNameFilter = new List<PatientModel>();
                    List<PatientModel> lastNameFilter = new List<PatientModel>();

                    // Create array based on the location of seperator 
                    var splitString = searchText.Split(',');

                    // Determine if too many seperators were used 
                    if(splitString.Length > 2)
                    {
                        // TODO: Create a small control that will pop up if a non allowed character is entered
                        MessageBox.Show("Too many uses of ,");
                        return;
                    }

                    // Set the split values into variables that will be used to determine search capabilities 
                    string lastName = splitString[0];
                    string firstName = splitString[1];

                    // filter by the last name
                    lastNameFilter = PatientListModel.Where(p => p.LastName.ToLower().Contains(lastName.ToLower())).ToList();

                    // filter by the first name
                    firstNameFilter = lastNameFilter.Where(p => p.FirstName.ToLower().Contains(firstName.ToLower())).ToList();

                    // Open new page 
                    MainWindow.AppWindow.DisplayPageFrame.Content = page;

                    // Set the itemsource to the completely filtered list 
                    page.PatientList.ItemsSource = firstNameFilter;

                    return;
                }

                // Searching the patient list via the text entered into the search bar 
                FilteredList = PatientListModel.Where(p => p.LastName.ToLower().Contains(SearchText.ToLower())).ToList();
                page.PatientList.ItemsSource = filteredList;

                // Sending the page frame the content
                MainWindow.AppWindow.DisplayPageFrame.Content = page;
            }
            else
            {
                // Setting itemsource to the entire list 
                page.PatientList.ItemsSource = PatientListModel;

                // Sending the page frame the content
                MainWindow.AppWindow.DisplayPageFrame.Content = page;
            }
        }

        public void UpdateSideMenuText()
        {
            MainWindow.AppWindow.SideMenu.FirstNameTextbox.Text = SelectedPatient.FirstName;
            MainWindow.AppWindow.SideMenu.LastNameTextBox.Text = SelectedPatient.LastName;
            MainWindow.AppWindow.SideMenu.DOBTextbox.Text = SelectedPatient.DOB;
            MainWindow.AppWindow.SideMenu.AddressTextbox.Text = SelectedPatient.Address;
            MainWindow.AppWindow.SideMenu.UpdateTextbox.Text = SelectedPatient.LastUpdate.ToString();
            MainWindow.AppWindow.SideMenu.CommaTextbox.Text = ",";
        }

        public static void RefreshPatientSearch()
        {
            MainWindow.AppWindow.DisplayPageFrame.Content = new PatientSearchPage();
        }

        /// <summary>
        /// Open an instance of the deletePatientWindow
        /// </summary>
        /// <param name="selectedPatient">Values from selected patient in the patient search page</param>
        public void OpenDeleteWindow(PatientModel selectedPatient)
        {
            var instance = new DeletePatientWindow(selectedPatient);
            instance.ShowDialog();
        }

        /// <summary>
        /// Open an instance of the updatePatientWindow
        /// </summary>
        /// <param name="selectedPatient">The selected patient from the patient Search page</param>
        public void OpenUpdateWindow(PatientModel selectedPatient)
        {
            var instance = new UpdatePatientWindow(selectedPatient);
            instance.FirstNameTextBox.Text = selectedPatient.FirstName;
            instance.LastNameTextBox.Text = selectedPatient.LastName;
            instance.DOBTextBox.Text = selectedPatient.DOB;
            instance.AddressTextBox.Text = selectedPatient.Address;
            instance.ShowDialog();
        }

        /// <summary>
        /// Check if the selected patient is null, if so return false 
        /// </summary>
        /// <param name="selectedPatient">Selected patient that will be passed from the view model</param>
        /// <returns></returns>
        public bool RequireSelectedPatient(PatientModel selectedPatient)
        {
            if (selectedPatient != null)
                return true;
            else
                return false;
        }

        public bool CheckSelectedPatient()
        {
            if (SelectedPatient != null)
                return true;
            else
                return false;
        }

        public void SelectPatient(PatientModel patient)
        {
            MainWindow.AppWindow.DisplayPageFrame.Content = new DrugListPage(patient);
        }

        public void ToggleVisibility()
        {
            if (SettingVisibility == Visibility.Visible)
                SettingVisibility = Visibility.Collapsed;

            else
                SettingVisibility = Visibility.Visible;
        }

        public void OpenAddDrugWindow()
        {
            AddDrugWindow instance = new AddDrugWindow();
            instance.ShowDialog();
        }

        public void OpenGeneralUseWindowCommand()
        {
            AddGeneralUseWindow instance = new AddGeneralUseWindow();
            instance.ShowDialog();
        }

        public void Return()
        {
            MainWindow.AppWindow.DisplayPageFrame.GoBack();
        }

        public void ReturnToDashboard()
        {
            MainWindow.AppWindow.DisplayPageFrame.Content = new CalendarPage();
        }

        #endregion
    }
}
