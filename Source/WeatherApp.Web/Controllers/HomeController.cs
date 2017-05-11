using System;
using System.Linq;
using System.Web.Mvc;
using NLog;
using WeatherApp.Services.Contracts;
using WeatherApp.Web.Models;

namespace WeatherApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICityService _cityService;
        private readonly ICountryService _countryService;
        private readonly ILogger _logger;
        private readonly IWeatherService _weatherService;

        /// <summary>
        ///     Home controller constructor injected with weather service, country service and city service
        /// </summary>
        /// <param name="weatherService">Weather Service</param>
        /// <param name="cityService">City Service</param>
        /// <param name="countryService">Country Service</param>
        public HomeController(IWeatherService weatherService, ICityService cityService, ICountryService countryService,
            ILogger logger)
        {
            _countryService = countryService;
            _cityService = cityService;
            _weatherService = weatherService;
            _logger = logger;
        }

        /// <summary>
        ///     Main view that loads when application starts
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            try
            {
                return View(new WeatherViewModel());
            }
            catch (Exception e)
            {
                _logger.Error(e);
                throw;
            }
        }

        /// <summary>
        ///     User search weather event
        /// </summary>
        /// <param name="model">WeatherViewModel</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(WeatherViewModel model)
        {
            try
            {
                if (string.IsNullOrEmpty(model.Country))
                {
                    model.Message = "Country name field cannot be empty!";
                    return View(model);
                }

                // Check if country user has entered exists
                var exists = _countryService.CheckCountryExists(model.Country);
                if (exists)
                {
                    model.Exists = true;
                    var cities = _cityService.GetCities(model.Country);

                    if (!cities.Any())
                        return View(model);

                    var cityList = cities.Select(item => new SelectListItem {Text = item.Name, Value = item.Name}).ToList();
                    model.Cities = cityList;

                    // If user has selected a city then get weather data for the city using weather service
                    if (!string.IsNullOrEmpty(model.SelectedCity))
                        model.Weather = _weatherService.GetWeather(model.SelectedCity);
                }
                else
                {
                    model.Message = $"Sorry, no data available for {model.Country}";
                }

                return View(model);
            }
            catch (Exception e)
            {
                _logger.Error(e);
                throw;
            }
        }
    }
}