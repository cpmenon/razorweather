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
    public class CityServiceTest
    {
        private ICityRepository _repo;
        private ICityService _service;
        [OneTimeSetUp]
        public void FixtureSetup()
        {
            _repo = new CityRepository();
            _service = new CityService(_repo);
        }

        [Test]
        public void GetCitiesTest()
        {
            var result = _service.GetCities("Australia");
            Assert.IsNotNull(result);
        }
    }
}
