using WebApp.Components.Pages;

namespace WebApp
{
    public class WetherApiClient
    {
        private readonly HttpClient _client;

        public WetherApiClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<Weather.WeatherForecast[]> GetWeatherAsync()
        {
            try
            {
                return await _client.GetFromJsonAsync<Weather.WeatherForecast[]>("weatherforecast");

            }
            catch (Exception)
            {}        
            
            return Array.Empty<Weather.WeatherForecast>();
        }
    }
}
