using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping.Order.BLL
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherForecastRepository repository;

        public WeatherService(IWeatherForecastRepository repository)
        {
            this.repository = repository;
        }
        public IEnumerable<WeatherForecast> Get(string cityName, int numberOfDays)
        {
            return repository.Get(cityName, numberOfDays);
        }
    }
}
