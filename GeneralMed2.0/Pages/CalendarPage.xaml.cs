using System.IO;
using System.Windows.Controls;

namespace GeneralMed2._0.Pages
{
    /// <summary>
    /// Interaction logic for Calendar.xaml
    /// </summary>
    public partial class CalendarPage : Page
    {
        public CalendarPage()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This will be used to determine if there is a text file containing the last city id
        /// If there is, then it will run the accuweather helper to allow for the information to be updated
        /// If not, then the values will be returned with default values 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

    }
}
