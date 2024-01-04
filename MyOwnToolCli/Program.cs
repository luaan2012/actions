using System.Net;
using System.Net.Http.Json;
using MyOwnToolCli;

const string apiKey = "d1b97c4958530b0ed9e6d1de200408e3";

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.openweathermap.org/")
};

var city = args.AsQueryable().FirstOrDefault();

Start:
if (city == null)
{
    Console.WriteLine("City name: ");
    city = Console.ReadLine()!.Trim();
}

var response = await httpClient.GetAsync($"data/2.5/weather?q={city}&appid={apiKey}&units=metric");

if (response.StatusCode == HttpStatusCode.NotFound)
{
    Console.WriteLine($"Weather not found for city: {city}");
    city = null;
    goto Start;
}

var currentWeather = await response.Content.ReadFromJsonAsync<WeatherContracts>();

Console.WriteLine($"Current weather in {city}");
Console.WriteLine($"City: {currentWeather.name}");
Console.WriteLine($"Country: {currentWeather?.sys.country}");
Console.WriteLine($"Weather: {currentWeather?.weather[0].description}");
Console.WriteLine($"Temperature: {currentWeather?.main.temp}C");
Console.WriteLine($"Humidity {currentWeather?.main.humidity}");
Console.WriteLine($"Pressure {currentWeather?.wind.speed}m/s, {currentWeather?.wind.deg}");
Console.WriteLine($"Clouds: {currentWeather?.clouds.all}%");