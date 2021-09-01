using Microsoft.AspNetCore.Mvc;
using Shopping.Oder.DAL;
using Shopping.Order.BLL;
using Shopping.Order.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Microsoft.Extensions.Logging;

namespace Shopping.Order.UnitTest
{
    public class WeatherForecastUnitTestController
    {
        //private DummyWeatherForecastRepository repository = new DummyWeatherForecastRepository();
        //private WeatherService ws = new WeatherService(repository);
        public WeatherForecastUnitTestController()
        {
        }
        [Fact]
        public async void Task_GetWeatherForecast_Return_OkResult1()
        {
           // IEnumerable<WeatherForecast> ff = new IEnumerable<WeatherForecast>(new WeatherForecast { Date = System.DateTime.Now.Date, Summary = "sf", TemperatureC = 32 });
            //Arrange
            var repoStub = new Mock<IWeatherService>();
            repoStub.Setup(repo => repo.Get("sydney", 2)).Returns((IEnumerable<WeatherForecast>)null);

            var logStub = new Mock<ILogger<WeatherForecastController>>();

            var controller = new WeatherForecastController(logStub.Object, repoStub.Object);

            ////Act
            var result = controller.Get("sydney", 2);

            ////Assert
            Assert.IsType<OkObjectResult>(result);

        }

    }
}
