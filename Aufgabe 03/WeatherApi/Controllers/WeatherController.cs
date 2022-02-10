using Microsoft.AspNetCore.Mvc;
using WeatherApi.Data;
using WeatherApi.Models;

namespace WeatherApi.Controllers
{
    [Route("data/2.5/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherDbContext WeatherDb;
        public WeatherController(WeatherDbContext context)
        {
            WeatherDb = context;
        }

        [HttpGet]
        public IActionResult GetWeatherByCity(string p, string appid)
        {
            WeatherData Weather = WeatherDb.Weathers.FirstOrDefault(b => b.name.ToLower().Contains(p.ToLower()));
            WeatherDataResp WeaterResp = new WeatherDataResp();

            if (Weather == null)
            {
                return NotFound();
            }

            WeaterResp.Id = Weather.Id;
            WeaterResp.name = Weather.name;
            WeaterResp.main.temp = Weather.temp;
            WeaterResp.main.feels_like = Weather.feels_like;
            WeaterResp.main.temp_min = Weather.temp_min;
            WeaterResp.main.temp_max = Weather.temp_max;
            WeaterResp.main.pressure = Weather.pressure;
            WeaterResp.main.humidity = Weather.humidity;
            WeaterResp.wind.speed = Weather.speed;
            WeaterResp.wind.deg = Weather.deg;

            return Ok(WeaterResp);
        }
    }
}
