using System.Collections.Generic;

namespace Shopping.Order.BLL
{
    public interface IWeatherForecastRepository
    {
        public IEnumerable<WeatherForecast> Get(string cityName, int numberOfDays);
    }
}