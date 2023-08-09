// ===========================================================================
/// <summary>
/// WeatherForecastController.cs
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 01.08.2023
/// </summary>
/// <created>ʆϒʅ, 01.08.2023</created>
/// <changed>ʆϒʅ, 09.08.2023</changed>
// ===========================================================================

using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi_shoper.Data;
using webapi_shoper.Models;

namespace webapi_shoper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Produces("application/json")]
    public class WeatherForecastController: ControllerBase
    {
        // not working ;\
        private readonly shoperSQLiteContext _context;

        public WeatherForecastController(shoperSQLiteContext context)
        {
            _context = context;
        }

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        /// <summary>
        /// return weather
        /// </summary>
        /// <remark>
        /// return weather remark
        /// </remark>
        /// <returns></returns>
        [HttpGet("action")]
        //[HttpGet("(id)")]
        public async Task<IActionResult> GetAction()
        {
            //var cart = new Cart();
            //cart.Id = 11;
            //cart.Size = Cart.CartSize.small;
            //_context.Carts.Add(cart);
            //await _context.SaveChangesAsync();
            //return Ok(_context.Find<Cart>(cart.Id));
            return Ok("Action");
        }
    }
}