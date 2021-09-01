using Shopping.Order.BLL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping.Oder.DAL
{
    public class DummyWeatherForecastRepository : IWeatherForecastRepository
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public IEnumerable<WeatherForecast> Get(string cityName, int numberOfDays)
        {
            IEnumerable<WeatherForecastDTO> dto = GetDummyData(numberOfDays);
            if (dto != null)
            {
                return GetDummyData(numberOfDays).Select(weatherData => new WeatherForecast
                {
                    Date = weatherData.Date,
                    Summary = weatherData.Summary,
                    TemperatureC = weatherData.Temperature
                });
            }
            else
            {
                return null;
            }
        }

        private static IEnumerable<WeatherForecastDTO> GetDummyData(int numberOfDays)
        {
            if (numberOfDays < 1)
            {
                return null;
            }
            var rng = new Random();
            return Enumerable.Range(1, numberOfDays).Select(index => new WeatherForecastDTO
            {
                Date = DateTime.Now.AddDays(index),
                Temperature = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

            //return null;
        }
    }
}
