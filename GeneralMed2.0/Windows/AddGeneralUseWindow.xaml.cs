using GeneralMed2._0.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GeneralMed2._0.Windows
{
    /// <summary>
    /// Interaction logic for AddGeneralUseWindow.xaml
    /// </summary>
    public partial class AddGeneralUseWindow : Window
    {
        public AddGeneralUseWindow()
        {
            InitializeComponent();
            AddGeneralUseWindowViewModel vm = new AddGeneralUseWindowViewModel();
            DataContext = vm;

            // Bind to the Close window action to close the window 
            if (vm.CloseWindowAction == null)
                vm.CloseWindowAction = new Action(this.Close);

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
