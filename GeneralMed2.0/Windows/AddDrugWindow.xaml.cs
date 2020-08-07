using System;
using System.Windows;
using System.Windows.Input;

namespace GeneralMed2._0.Windows
{
    /// <summary>
    /// Interaction logic for AddDrugWindow.xaml
    /// </summary>
    public partial class AddDrugWindow : Window
    {
        public AddDrugWindow()
        {
            AddDrugWindowViewModel vm = new AddDrugWindowViewModel();
            DataContext = vm;
            InitializeComponent();

            // This is an interesting pay to close the window through the view model
            if (vm.CloseAction == null)
                vm.CloseAction = new Action(this.Close);

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
