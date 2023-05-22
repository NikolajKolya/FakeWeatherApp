using FakeWeatherApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FakeWeatherApp.Models.Enums;
using FakeWeatherApp.Models.ViewModels;
using FakeWeatherApp.Services;
using FakeWeatherApp.Services.Abstract;
using FakeWeatherApp.Services.Implementations;

namespace FakeWeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IWeatherService _weatherService;
        
        public HomeController
        (
            ILogger<HomeController> logger,
            IWeatherService weatherService
        )
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        public async Task<IActionResult> CurrentWeather()
        {

            var model = new CurrentWeatherViewModel()
            {
                Weather = await _weatherService.GenerateWeatherAsync()
            };
            
            return View(model);
        }
        
        public async Task<IActionResult> WeekForecast()
        {
            var forecast = new List<WeatherDto>();
            for (int i = 0; i < 7; i++)
            {
                forecast.Add(await _weatherService.GenerateWeatherAsync()); 
            }
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