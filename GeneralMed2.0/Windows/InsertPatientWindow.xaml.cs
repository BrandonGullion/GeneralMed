using GeneralMed2._0.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace GeneralMed2._0.Windows
{
    /// <summary>
    /// Interaction logic for InsertPatientWindow.xaml
    /// </summary>
    public partial class InsertPatientWindow : Window
    {
        public InsertPatientWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            // Check if all the text boxes have been properly filled in 
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) || string.IsNullOrWhiteSpace(LastNameTextBox.Text) || string.IsNullOrWhiteSpace(DOBTextbox.Text))
            {
                MessageBox.Show("Please fill in all appropriate fields");
                return;
            }

            // Assign all the values to the current patient model to be saved 
            PatientModel patientModel = new PatientModel()
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                DOB = DOBTextbox.Text,
                Address = AddressTextbox.Text,
                DateCreated = DateTime.Now.ToString("MMMM dd, yyyy"),
                LastUpdate = DateTime.Now.ToString("MMMM dd, yyyy"),
            };

            using(SQLiteConnection connection = new SQLiteConnection(DatabaseHelper.databasePath))
            {
                // Check if the table is present 
                connection.CreateTable<PatientModel>();

                // Insert the patient into the table 
                connection.Insert(patientModel);
            }

            Close();
            CentralViewModel.RefreshPatientSearch();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
            CentralViewModel.RefreshPatientSearch();
        }
    }
}
