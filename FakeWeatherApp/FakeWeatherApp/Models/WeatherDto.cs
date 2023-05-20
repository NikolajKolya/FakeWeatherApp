using FakeWeatherApp.Models.Enums;

namespace FakeWeatherApp.Models;

public class WeatherDto
{
    public double Temperature { get; set; }
    
    public double Humidity { get; set; }
    
    public WeatherType Type { get; set; }
}