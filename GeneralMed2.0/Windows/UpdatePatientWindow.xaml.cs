using GeneralMed2._0.Models;
using GeneralMed2._0.Pages;
using System.Windows;
using System.Windows.Input;

namespace GeneralMed2._0.Windows
{
    /// <summary>
    /// Interaction logic for UpdatePatientWindow.xaml
    /// </summary>
    public partial class UpdatePatientWindow : Window
    {
        public PatientModel SelectedPatient { get; set; }

        public UpdatePatientWindow(PatientModel selectedPatient)
        {
            InitializeComponent();
            SelectedPatient = selectedPatient;
        }

        private void WindowHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void UpdatePatientButton_Click(object sender, RoutedEventArgs e)
        {
            DatabaseHelper.UpdatePatient(SelectedPatient, FirstNameTextBox.Text,LastNameTextBox.Text, DOBTextBox.Text, AddressTextBox.Text);
            Close();
            MainWindow.AppWindow.DisplayPageFrame.Content = new PatientSearchPage();
        }
    }
}
