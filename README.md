<div align="center">

# CS-OWM (Csharp-OpenWeatherMap)

[![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/) [![License: MIT](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)](https://opensource.org/licenses/MIT)

*A simple C# application that uses the OpenWeatherMap API to fetch weather information for a specific location.*
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
This application uses the OpenWeatherMap API to retrieve weather data based on a city's name and displays details such as:
- 🌡️ Temperature and "feels like" temperature
- 💧 Humidity
- 🌬️ Wind speed and direction
- 🌫️ Visibility
- 🌤️ Weather status

---

## 📋 Requirements
- .NET SDK 6.0 or higher
- OpenWeatherMap API Key
- Internet connection

---

## ⚙️ How to Use
Run the application to get the current weather information for a city (e.g., Ho Chi Minh City):
```bash
$ dotnet run
```

### Example Output:
```
Current weather in Ho Chi Minh City - Latitude: [10.8231] Longitude: [106.6297]:
Current datetime: 16-12-2024 - 10:30
Weather:
Temperature: 30.5°C feel like 35.0°C
Pressure: 1012 hPa
Humidity: 65%
Sea level: 1013 hPa - Ground level: 1010 hPa
Visibility: 10 km
Wind:
Wind speed: 3.5 m/s
Wind degrees: 180°
Wind gust: 5.0 m/s
Cloud:
Cloudiness: 20%
Status: Clear - clear sky
```

---

## 📂 Project Structure
```
WeatherApp/
├── Program.cs                // The main entry point of the application
├── WeatherService.cs         // Service to call OpenWeatherMap API
├── Models/
│   ├── WeatherData.cs        // Class for weather data
│   ├── Coord.cs              // Class for location data
│   ├── Weather.cs            // Class for weather status
│   ├── DetailsWeather.cs     // Class for detailed temperature and pressure data
│   ├── Wind.cs               // Class for wind data
│   └── Clouds.cs             // Class for cloud data
└── ...              // Project documentation
```

---

## 🚀 Setup Guide

### 1. Clone the Repository
```bash
git clone https://github.com/nupniichan/cs-owm.git
cd WeatherApp
```

### 2. Add Your OpenWeatherMap API Key
- Open `Program.cs` and replace `YOUR_API_KEY_HERE` with your API key.
```csharp
string api = "YOUR_API_KEY_HERE";
```

### 3. Run the Application
```bash
dotnet run
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

