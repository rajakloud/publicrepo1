using System.Collections.Generic;

namespace Shopping.Order.BLL
{
    public interface IWeatherService
    {
        public IEnumerable<WeatherForecast> Get(string cityName, int numberOfDays);
    }
}