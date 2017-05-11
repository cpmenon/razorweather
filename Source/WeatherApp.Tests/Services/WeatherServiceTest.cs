using System;
using NUnit.Framework;
using WeatherApp.Data.Contracts;
using WeatherApp.Data.Repository;
using WeatherApp.Services;
using WeatherApp.Services.Contracts;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace WeatherApp.Tests.Services
{
    [TestFixture]
    public class WeatherServiceTest
    {
        private IWeatherRepository _repo;
        private IWeatherService _service;
        [OneTimeSetUp]
        public void FixtureSetup()
        {
            _repo = new WeatherRepository();
            _service = new WeatherService(_repo);
        }

        [Test]
        public void GetWeatherTest()
        {
            var result = _service.GetWeather("Melbourne");
            Assert.IsNotNull(result);
        }

        [Test]
        public void GetWeatherNotExistTest()
        {
            var result = _service.GetWeather("wellington");
            Assert.IsNull(result);
        }
    }
}
