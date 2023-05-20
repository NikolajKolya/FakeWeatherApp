namespace FakeWeatherApp.Models.ViewModels;

public class WeatherForecastViewModel
{
    public IReadOnlyCollection<WeatherDto> Forecast { get; set; }
}