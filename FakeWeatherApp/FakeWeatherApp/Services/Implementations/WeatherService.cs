using FakeWeatherApp.Models;
using FakeWeatherApp.Models.Enums;
using FakeWeatherApp.Services.Abstract;

namespace FakeWeatherApp.Services.Implementations;

public class WeatherService : IWeatherService
{
    public Random _randomGenerator = new Random();

    public async Task<WeatherDto> GenerateWeatherAsync()
    {
        return new WeatherDto()
        {
            Temperature = _randomGenerator.Next(-5, 50),
            Humidity = _randomGenerator.Next(0, 100),
            Type = (WeatherType)_randomGenerator.Next(0, 3)
        };
    }
}