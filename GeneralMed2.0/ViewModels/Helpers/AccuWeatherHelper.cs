using GeneralMed2_0;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GeneralMed2._0
{

    // Copied full location api url 
    // http://dataservice.accuweather.com/locations/v1/cities/autocomplete?apikey=R4P2iUuQCGNjcmSM2VK8hfzcqupUlEHW&q=san%20f

    // Copied full current condition api url
    // http://dataservice.accuweather.com/currentconditions/v1/265318?apikey=R4P2iUuQCGNjcmSM2VK8hfzcqupUlEHW

    public class AccuWeatherHelper
    {
        // Autocomplete 
        public const string BASE_URL = "http://dataservice.accuweather.com/";
        public const string API_KEY = "R4P2iUuQCGNjcmSM2VK8hfzcqupUlEHW";
        public const string AUTOCOMPLETE_ENDPOINT = "locations/v1/cities/autocomplete?apikey={0}&q={1}";

        // Current Conditions 
        public const string CURRENT_CONDITIONS_ENDPOINT = "currentconditions/v1/{0}?apikey={1}";

        public static async Task<List<CityModel>> GetCities(string query)
        {
            List<CityModel> cities = new List<CityModel>();

            // Using string.format to insert the api key and the query into the url to send to accu weather 
            string url = BASE_URL + string.Format(AUTOCOMPLETE_ENDPOINT, API_KEY, query);

            using (HttpClient client = new HttpClient())
            {
                // Send out a request for the api
                var response = await client.GetAsync(url);

                // Awaiting the response and saving the information as a string (it will be formatted json)
                string json = await response.Content.ReadAsStringAsync();

                // Saving the converted list of cities from the website into a variable 
                cities = JsonConvert.DeserializeObject<List<CityModel>>(json);
            }

            return cities;
        }

        public static async Task<CurrentConditionsModel> GetCurrentConditionsAsync(string cityKey)
        {
            CurrentConditionsModel CurrentConditionsModel = new CurrentConditionsModel();

            string url = BASE_URL + string.Format(CURRENT_CONDITIONS_ENDPOINT, cityKey, API_KEY);

            using (HttpClient client = new HttpClient())
            {
                // Send out a request for the api
                var response = await client.GetAsync(url);

                // Awaiting the response and saving the information as a string (it will be formatted json)
                string json = await response.Content.ReadAsStringAsync();

                // The website returns a json of listed current conditions, therefore we use the first
                // or default to make sure that we grab the first object of the list only, because 
                // We only want to return one thing, not an entire list 
                CurrentConditionsModel = (JsonConvert.DeserializeObject<List<CurrentConditionsModel>>(json)).FirstOrDefault();
            }

            return CurrentConditionsModel;
        }
    }
}
