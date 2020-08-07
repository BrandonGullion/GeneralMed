using GeneralMed2._0.Models;
using System;
using System.Windows;

namespace GeneralMed2._0.Windows
{
    /// <summary>
    /// Interaction logic for DeletePatientWindow.xaml
    /// </summary>
    public partial class DeletePatientWindow : Window
    {
        public PatientModel SelectedPatient { get; set; }

        public DeletePatientWindow(PatientModel selectedPatient)
        {
            SelectedPatient = selectedPatient;
            InitializeComponent();
        }

        private void WindowHeader_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Delete the current Selected Patient 
            // Add function to delete the patient through a relay command 
            if (SelectedPatient != null)
            {
                DatabaseHelper.DeletePatientFromDB(SelectedPatient);
                Close();
            }
            else
                MessageBox.Show("Error: Selected Patient Is null");

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
