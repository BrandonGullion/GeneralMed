using GeneralMed2._0.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GeneralMed2._0.Pages
{
    /// <summary>
    /// Interaction logic for DrugListPage.xaml
    /// </summary>
    public partial class DrugListPage : Page
    {
        public DrugListPage(PatientModel patient)
        {
            DataContext = new DrugListPageViewModel(patient);
            InitializeComponent();
        }
    }
}
