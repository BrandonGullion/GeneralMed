using GeneralMed2._0.Models;
using GeneralMed2._0.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GeneralMed2._0.Commands
{
    public class OpenDeletePatientWindowCommand : ICommand
    {
        public PatientModel SelectedPatient { get; set; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var instance = new DeletePatientWindow(SelectedPatient);
            instance.ShowDialog();
        }

        public OpenDeletePatientWindowCommand(PatientModel selectedPatient)
        {
            SelectedPatient = selectedPatient;
        }
    }
}
