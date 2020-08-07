using System;
using System.Windows;

namespace GeneralMed2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // This is god damn incredible, Creating a static source for the main window
        // Allows for the access of any controls within its level, meaning that the 
        // 
        public static MainWindow AppWindow;

        public MainWindow()
        {
            InitializeComponent();
            AppWindow = this;
        }

        /// <summary>
        /// Main window was having trouble closing, override the OnClosed event to make sure
        /// that the current application closes 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
    }
}
