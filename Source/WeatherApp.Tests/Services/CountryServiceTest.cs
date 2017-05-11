using System;
using NUnit.Framework;
using WeatherApp.Data.Contracts;
using WeatherApp.Data.Repository;
using WeatherApp.Services;
using WeatherApp.Services.Contracts;

namespace WeatherApp.Tests.Services
{
    [TestFixture]
    public class CountryServiceTest
    {
        private ICountryRepository _repo;
        private ICountryService _service;
        [OneTimeSetUp]
        public void FixtureSetup()
        {
            _repo = new CountryRepository();
            _service = new CountryService(_repo);
        }

        [Test]
        public void CheckCountryExistsTest()
        {
            var result = _service.CheckCountryExists("Australia");
            Assert.AreEqual(true, result);
        }
    }
}
