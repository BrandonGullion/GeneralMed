using GeneralMed2._0.Windows;
using System;
using System.Windows.Input;

namespace GeneralMed2._0
{
    public class OpenUpdatePatientWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //var instance = new UpdatePatientWindow();
            //instance.ShowDialog();
        }
    }
}
