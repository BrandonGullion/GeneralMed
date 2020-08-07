using System;
using System.Windows.Input;

namespace GeneralMed2._0.Commands
{
    public class OpenCitySearchCommand : ICommand
    {
        public AccuWeatherViewModel VM { get; set; }

        public event EventHandler CanExecuteChanged;

        public OpenCitySearchCommand(AccuWeatherViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.OpenSearchWindow();
        }
    }
}
