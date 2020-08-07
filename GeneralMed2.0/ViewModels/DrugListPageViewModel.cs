using GalaSoft.MvvmLight.Command;
using GeneralMed2._0.Models;
using GeneralMed2._0.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace GeneralMed2._0
{
    public class DrugListPageViewModel : BasePropertyChanged
    {
        #region Properties

        private PatientDrugModel selectedPatientDrugModel;

        public PatientDrugModel SelectedPatientDrugModel
        {
            get { return selectedPatientDrugModel; }
            set { selectedPatientDrugModel = value; OnPropertyChanged(nameof(SelectedPatientDrugModel)); DeleteSelectedDrugCommand.RaiseCanExecuteChanged(); }
        }


        private string selectedStrength;

        public string SelectedStrength
        {
            get { return selectedStrength; }
            set { selectedStrength = value; OnPropertyChanged(nameof(selectedStrength)); AddDrugCommand.RaiseCanExecuteChanged(); }
        }


        private DrugModel selectedDrugModel;

        public DrugModel SelectedDrugModel
        {
            get { return selectedDrugModel; }
            set 
            { 
                selectedDrugModel = value; 
                OnPropertyChanged(nameof(SelectedDrugModel));  

                // null check if the selected value for some reason becomes null
                if (SelectedDrugModel != null)
                    LocalDrugModel = SelectedDrugModel;

                AddDrugCommand.RaiseCanExecuteChanged();
            }
        }

        private DrugModel localDrugModel;

        public DrugModel LocalDrugModel
        {
            get { return localDrugModel; }
            set { localDrugModel = value; OnPropertyChanged(nameof(LocalDrugModel)); }
        }



        private PatientModel patient;

        public PatientModel Patient
        {
            get { return patient; }
            set { patient = value; OnPropertyChanged(nameof(Patient)); }
        }


        private ObservableCollection<PatientDrugModel> filteredPatientDrugModelList;

        public ObservableCollection<PatientDrugModel> FilteredPatientDrugModelList
        {
            get { return filteredPatientDrugModelList; }
            set { filteredPatientDrugModelList = value; OnPropertyChanged(nameof(FilteredPatientDrugModelList)); }
        }


        public List<DrugModel> DrugList { get; set; }

        public List<PatientDrugModel> PatientDrugList { get; set; }

        #endregion

        #region Constructor
        public DrugListPageViewModel(PatientModel patientModel)
        {
            #region Commands

            AddDrugCommand = new RelayCommand(() => AddDrug(), () => CheckAddDrug());

            DeleteSelectedDrugCommand = new RelayCommand(() => DeleteDrug(), () => CheckSelectedDrug());

            ExportCommand = new RelayCommand(() => Export());

            HomeCommand = new RelayCommand(() => ReturnToDashboard());

            BackButtonCommand = new RelayCommand(() => Return());

            #endregion

            // Create the drug list to bind to the Combobox 
            DrugList = new List<DrugModel>();
            DrugList = DatabaseHelper.ReadDrugDB(DrugList);

            // Create the patientdrug list that will be filtered 
            PatientDrugList = new List<PatientDrugModel>();
            PatientDrugList = DatabaseHelper.ReadPatientDrugModelDB(PatientDrugList);

            Patient = patientModel;

            // Creating instance of list that will be the finalized values 
            FilteredPatientDrugModelList = new ObservableCollection<PatientDrugModel>();
            FilteredPatientDrugModelList = filterByPatient();


        }

        #endregion

        #region Commands

        public RelayCommand AddDrugCommand { get; set; }

        public RelayCommand DeleteSelectedDrugCommand { get; set; }

        public RelayCommand ExportCommand { get; set; }
        public RelayCommand HomeCommand { get; set; }
        public RelayCommand BackButtonCommand { get; set; }

        #endregion

        #region Methods

        public ObservableCollection<PatientDrugModel> filterByPatient()
        {
            ObservableCollection<PatientDrugModel> filteredList = new ObservableCollection<PatientDrugModel>();

            // Checks to see if there are any patient models on the patientdrug list that match id's, if they do then it will
            // retrun them to the filtered list that can be used to display the drugs without additional items from the list 
            foreach(var p in PatientDrugList)
                if (p.PatientId == Patient.Id)
                    filteredList.Add(p);

            return filteredList;
        }

        public void AddDrug()
        {
            DatabaseHelper.AddPatientDrugModel(Patient, LocalDrugModel, SelectedStrength);
            PatientDrugList = DatabaseHelper.ReadPatientDrugModelDB(PatientDrugList);
            FilteredPatientDrugModelList = filterByPatient();
        }

        public bool CheckAddDrug()
        {
            if (LocalDrugModel != null && SelectedStrength != null)
                return true;
            else
                return false;
        }

        public void DeleteDrug()
        {
            DatabaseHelper.DeletePatientDrugModel(SelectedPatientDrugModel);
            PatientDrugList = DatabaseHelper.ReadPatientDrugModelDB(PatientDrugList);
            FilteredPatientDrugModelList = filterByPatient();
        }

        public bool CheckSelectedDrug()
        {
            if (SelectedPatientDrugModel != null)
                return true;
            else
                return false;
        }

        public void Export()
        {
            if(Patient != null)
            {
                DocumentCreator document = new DocumentCreator(Patient.FirstName, Patient.LastName, Patient.DOB, Patient.Address, Patient.LastUpdate, FilteredPatientDrugModelList);
                document.CreateDocument();
            }
            else
            {
                MessageBox.Show("You found a bug!!! Please inform app creator!");
            }
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
