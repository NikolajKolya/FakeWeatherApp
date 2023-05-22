using FakeWeatherApp.Models;

namespace FakeWeatherApp.Services.Abstract;

public interface IWeatherService
{
    Task<WeatherDto> GenerateWeatherAsync();
}