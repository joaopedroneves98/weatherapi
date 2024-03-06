namespace WeatherApi.Controllers
{
    using System.Net;

    using Application.Interfaces;

    using Domain.Entities;

    using Microsoft.AspNetCore.Mvc;
    
    [ApiController]
    [Route("weather")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        
        public WeatherController(IWeatherService weatherService)
        {
            this._weatherService = weatherService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(WeatherForecast), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetWeatherForecastByCity([FromQuery] string city)
        {
            var result = await this._weatherService.GetWeatherByCityAsync(city);
            
            return this.Ok(result);
        }
    }
}