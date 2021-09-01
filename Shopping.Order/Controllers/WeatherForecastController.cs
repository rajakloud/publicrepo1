using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping.Order.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Order.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherService service;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService service)
        {
            _logger = logger;
            this.service = service;
        }

        //public WeatherForecastController(IWeatherService service)
        //{
        //    this.service = service;
        //}

        [HttpGet]
        public IActionResult Get(string cityName="Sydney",  int numberOfDays = 3)
        {
            //return service.Get(cityName, numberOfDays);
            IEnumerable<WeatherForecast> wf = service.Get(cityName, numberOfDays);
            return Ok(wf);
        }
    }
}
