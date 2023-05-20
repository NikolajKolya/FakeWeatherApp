using FakeWeatherApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
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
            return View();
        }
        
        public IActionResult WeekForecast()
        {
            return View();
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