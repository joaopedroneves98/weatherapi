namespace Application.Interfaces
{
    using Domain.Entities;
    
    public interface IWeatherService
    {
        Task<WeatherForecast> GetWeatherByCityAsync(string city);
    }
}