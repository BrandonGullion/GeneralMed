using System;
using System.Windows;
using System.Windows.Input;

namespace GeneralMed2._0
{
    public class CitySearchCommand : ICommand
    {
        public AccuWeatherViewModel VM { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (string.IsNullOrWhiteSpace((string)parameter))
                return false;
            else
                return true;
        }

        public void Execute(object parameter)
        {
            VM.AccuWeatherQuery();
        }

        #region Constructor 

        public CitySearchCommand(AccuWeatherViewModel vm)
        {
            VM = vm;
        }

        #endregion
    }
}
