namespace Domain.Abstractions
{
    using Entities;
    public interface IWeatherProviderGateway
    {
        WeatherForecast GetWeatherByCityAsync(string city); //No Task for now
    }
}