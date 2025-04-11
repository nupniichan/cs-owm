<div align="center">

# CS-OWM (CSharp OpenWeatherMap)

[![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/) [![License: MIT](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)](https://opensource.org/licenses/MIT)

*A C# library for integrating with the OpenWeatherMap API to fetch detailed weather information for any location.*
</div>

---

## 📖 Table of Contents
- [📢 Introduction](#-introduction)
- [📋 Requirements](#-requirements)
- [⚙️ How to Use](#️-how-to-use)
- [📂 Project Structure](#-project-structure)
- [🚀 Setup Guide](#-setup-guide)
- [🤝 Contributing](#-contributing)
- [📜 License](#-license)

---

## 📢 Introduction
This library provides a simple way to integrate with the OpenWeatherMap API in your C# applications. It offers comprehensive weather data retrieval including:
- 🌡️ Temperature and "feels like" temperature
- 💧 Humidity
- 🌬️ Wind speed, direction, and gusts
- 🌫️ Visibility
- 🌤️ Weather status with icon support
- 📍 Location coordinates
- 🕒 Local time with timezone offset

---

## 📋 Requirements
- .NET SDK 6.0 or higher
- OpenWeatherMap API Key
- Internet connection
- Newtonsoft.Json package

---

## ⚙️ How to Use

### 1. Install the Package
```bash
dotnet add package CsOwm
```

### 2. Initialize the Service
```csharp
using CsOwm.Service;

// Initialize the service with your API key
var weatherService = new CsOwmService("YOUR_API_KEY");
```

### 3. Get Weather Data
```csharp
// Get weather data for a location
var weatherData = await weatherService.GetWeatherDataAsync("City Name");

// Get weather icon URL
var iconUrl = weatherService.GetWeatherIconUrl(weatherData.weather.icon);
```

### Example Usage:
```csharp
using CsOwm.Service;
using CsOwm.Models;

public class WeatherApp
{
    private readonly CsOwmService _weatherService;

    public WeatherApp(string apiKey)
    {
        _weatherService = new CsOwmService(apiKey);
    }

    public async Task DisplayWeather(string location)
    {
        var weatherData = await _weatherService.GetWeatherDataAsync(location);
        
        Console.WriteLine($"Current weather in {location} - Latitude: [{weatherData.coord.Latitude}] Longitude: [{weatherData.coord.Longitude}]");
        Console.WriteLine($"Current datetime: {weatherData.localTime}");
        Console.WriteLine($"Weather:");
        Console.WriteLine($"Temperature: {weatherData.main.temp}°C feel like {weatherData.main.feels_like}°C");
        Console.WriteLine($"Pressure: {weatherData.main.pressure} hPa");
        Console.WriteLine($"Humidity: {weatherData.main.humidity}%");
        Console.WriteLine($"Sea level: {weatherData.main.sea_level} hPa - Ground level: {weatherData.main.grnd_level} hPa");
        Console.WriteLine($"Visibility: {weatherData.Visibility} km");
        Console.WriteLine($"Wind:");
        Console.WriteLine($"Wind speed: {weatherData.wind.speed} m/s");
        Console.WriteLine($"Wind degrees: {weatherData.wind.deg}°");
        Console.WriteLine($"Wind gust: {weatherData.wind.gust} m/s");
        Console.WriteLine($"Cloud:");
        Console.WriteLine($"Cloudiness: {weatherData.clouds.all}%");
        Console.WriteLine($"Status: {weatherData.weather.main} - {weatherData.weather.description}");
    }
}
```

---

## 📂 Project Structure
```
cs-owm/
├── Service/
│   └── CsOwmService.cs        // Service for OpenWeatherMap API integration
├── Models/
    ├── WeatherData.cs         // Main weather data model
    ├── Coord.cs               // Location coordinates
    ├── Weather.cs             // Weather status and description
    ├── DetailsWeather.cs      // Temperature and pressure details
    ├── Wind.cs                // Wind information
    └── Clouds.cs              // Cloud coverage data
```

---

## 🚀 Setup Guide

### 1. Clone the Repository
```bash
git clone https://github.com/nupniichan/cs-owm.git
cd cs-owm
```

### 2. Build the Library
```bash
dotnet build
```

### 3. Add to Your Project
Add a reference to the library in your project:
```bash
dotnet add reference path/to/cs-owm
```

---

## 🤝 Contributing
Contributions are welcome! Feel free to:
- ⭐ Star this repository
- 🐛 Report issues
- ✨ Request new features
- 🔧 Submit pull requests

---

## 📜 License
This project is licensed under the MIT License. See the [LICENSE](https://github.com/nupniichan/cs-owm/blob/main/LICENSE.txt) file for more details.

---

<div align="center">✨ Thank you for visiting this repository! ✨</div>

