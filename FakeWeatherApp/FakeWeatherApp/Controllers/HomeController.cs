using FakeWeatherApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FakeWeatherApp.Models.Enums;
using FakeWeatherApp.Models.ViewModels;

namespace FakeWeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult CurrentWeather()
        {

            var model = new CurrentWeatherViewModel()
            {
                Weather = new WeatherDto()
                {
                    Temperature = 36,
                    Humidity = 58,
                    Type = WeatherType.Clear
                }
            };
            
            return View(model);
        }
        
        public IActionResult WeekForecast()
        {
            var forecast = new List<WeatherDto>()
            {
                new WeatherDto() { Temperature = 20, Humidity = 50, Type = WeatherType.Clear},
                new WeatherDto() { Temperature = 22, Humidity = 55, Type = WeatherType.Clear},
                new WeatherDto() { Temperature = 24, Humidity = 60, Type = WeatherType.Cloudy},
                new WeatherDto() { Temperature = 26, Humidity = 58, Type = WeatherType.Clear},
                new WeatherDto() { Temperature = 28, Humidity = 70, Type = WeatherType.Rain},
                new WeatherDto() { Temperature = 30, Humidity = 75, Type = WeatherType.Rain},
                new WeatherDto() { Temperature = 32, Humidity = 73, Type = WeatherType.Cloudy}
            };

            var model = new WeatherForecastViewModel()
            {
                Forecast = forecast
            };
            
            return View(model);
        }
        
        public IActionResult Index()
        {
            var model = new HomeViewModel()
            {
                CityName = "Подгорица"
            };
            
            return View(model);
        }
    }
}