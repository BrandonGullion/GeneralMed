using GeneralMed2._0.Commands;
using GeneralMed2._0.Pages;
using GeneralMed2_0;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GeneralMed2._0
{
    public class AccuWeatherViewModel : BasePropertyChanged
    {
        #region Properties

        // Propfull

        private string query;
        public string Query
        {
            get { return query; }
            set { query = value;  OnPropertyChanged(nameof(Query)); }
        }

        public ObservableCollection<CityModel> Cities { get; set; }


        private CurrentConditionsModel currentConditionsModel;

        public CurrentConditionsModel CurrentConditionsModel
        {
            get { return currentConditionsModel; }
            set { currentConditionsModel = value; OnPropertyChanged(nameof(CurrentConditionsModel)); }
        }


        private CityModel city;

        public CityModel City
        {
            get { return city; }
            set { city = value; OnPropertyChanged(nameof(City)); }
        }


        private CityModel selectedCityModel;

        public CityModel SelectedCityModel
        {
            get { return selectedCityModel; }
            set 
            {   
                selectedCityModel = value; 
                OnPropertyChanged(nameof(SelectedCityModel));
                GetCurrentConditions();
            }
        }

        #endregion

        #region Commands

        public OpenCitySearchCommand OpenCitySearchCommand { get; set; }
        public CitySearchCommand CitySearchCommand { get; set; }

        #endregion

        #region Constructor 

        public AccuWeatherViewModel()
        {
            OpenCitySearchCommand = new OpenCitySearchCommand(this);
            CitySearchCommand = new CitySearchCommand(this);

            // Create an instance of the observable collection 
            Cities = new ObservableCollection<CityModel>();

        }

        #endregion

        #region Methods

        public void OpenSearchWindow()
        {
            CitySearchWindow instance = new CitySearchWindow();
            instance.ShowDialog();
        }

        public async void AccuWeatherQuery()
        {
            var cities = await AccuWeatherHelper.GetCities(Query);

            Cities.Clear();

            foreach (var city in cities)
            {
                Cities.Add(city);
            }
        }

        public async void GetCurrentConditions()
        {
            Query = string.Empty;
            try
            {
                CurrentConditionsModel = await AccuWeatherHelper.GetCurrentConditionsAsync(SelectedCityModel.Key);
            }
            catch
            {
                System.Windows.MessageBox.Show("Error");
            }

            var updatedPage = new CalendarPage();
            updatedPage.WeatherTextTexBlock.Text = CurrentConditionsModel.WeatherText;
            updatedPage.CurrentTempTextBlock.Text = CurrentConditionsModel.Temperature.Metric.Value.ToString();

            updatedPage.CityTextBlock.Text = SelectedCityModel.LocalizedName;

            #region Change Weather Icons

            if (Enumerable.Range(1, 2).Contains(CurrentConditionsModel.WeatherIcon))
                updatedPage.IconImage.Source = new BitmapImage(new Uri("/Icons/Sunny.png", UriKind.Relative));

            if (Enumerable.Range(3, 4).Contains(CurrentConditionsModel.WeatherIcon))
                updatedPage.IconImage.Source = new BitmapImage(new Uri("/Icons/PartlyCloudy.png", UriKind.Relative));

            if (Enumerable.Range(5, 5).Contains(CurrentConditionsModel.WeatherIcon))
                updatedPage.IconImage.Source = new BitmapImage(new Uri("/Icons/Sunny.png", UriKind.Relative));

            if (Enumerable.Range(6, 11).Contains(CurrentConditionsModel.WeatherIcon))
                updatedPage.IconImage.Source = new BitmapImage(new Uri("/Icons/Cloudy.png", UriKind.Relative));

            if (Enumerable.Range(12, 14).Contains(CurrentConditionsModel.WeatherIcon))
                updatedPage.IconImage.Source = new BitmapImage(new Uri("/Icons/Rainfall.png", UriKind.Relative));

            if (Enumerable.Range(15, 17).Contains(CurrentConditionsModel.WeatherIcon))
                updatedPage.IconImage.Source = new BitmapImage(new Uri("/Icons/ThunderStorm.png", UriKind.Relative));

            if (Enumerable.Range(18, 18).Contains(CurrentConditionsModel.WeatherIcon))
                updatedPage.IconImage.Source = new BitmapImage(new Uri("/Icons/Rainfall.png", UriKind.Relative));

            if (Enumerable.Range(15, 17).Contains(CurrentConditionsModel.WeatherIcon))
                updatedPage.IconImage.Source = new BitmapImage(new Uri("/Icons/ThunderStorm.png", UriKind.Relative));

            #endregion

            MainWindow.AppWindow.DisplayPageFrame.Content = updatedPage;

        }

        public void WriteCityIdToFile(string CityId)
        {
            // Write the city id to a text file to be later opened
            File.WriteAllText(CentralViewModel.Path, CityId);
        }



        #endregion
    }
}
