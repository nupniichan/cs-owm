using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Put your OpenWeatherMap API here
        string api = "YOUR_API_KEY_HERE";
        var httpClient = new HttpClient();
        var weatherService = new WeatherService(api);

        // Example location
        var location = "Tokyo";

        // Get data
        var weatherData = await weatherService.GetWeatherDataAsync(location);

        // Example usage
        if (weatherData != null)
        {
            Console.WriteLine($"Current weather in {location} - Latitude: [{weatherData.coord.Longitude}] Longitude: [{weatherData.coord.Latitude}]:");
            Console.WriteLine($"Current country datetime: {weatherData.localTime} ({weatherData.localTime})");
            Console.WriteLine($"Weather:");
            Console.WriteLine($"Temperature: {weatherData.main.temp}°C feel like {weatherData.main.feels_like}°C");
            Console.WriteLine($"Pressure: {weatherData.main.pressure} hPa");
            Console.WriteLine($"Humidity: {weatherData.main.humidity}%");
            Console.WriteLine($"Sea level: {weatherData.main.sea_level} hPa - Ground level: {weatherData.main.grnd_level} hPa");
            Console.WriteLine($"Visibility: {weatherData.Visibility / 1000} km");
            Console.WriteLine($"Wind:");
            Console.WriteLine($"Wind speed: {weatherData.wind.speed} m/s");
            Console.WriteLine($"Wind degrees: {weatherData.wind.deg}°");
            Console.WriteLine($"Wind gust: {weatherData.wind.gust} m/s");
            Console.WriteLine($"Cloud:");
            Console.WriteLine($"Cloudiness: {weatherData.clouds.all}%");
            Console.WriteLine($"Icon url: {weatherService.GetWeatherIconUrl(weatherData.weather.icon)}");
            Console.WriteLine($"Status: {weatherData.weather.main} - {weatherData.weather.description}");
        }
        else
        {
            Console.WriteLine("Can't get weather data. Is something wrong?");
        }
    }
}
