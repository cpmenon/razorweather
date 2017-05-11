using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Data.Contracts;
using WeatherApp.Services.Contracts;
using WeatherApp.Services.Models;

namespace WeatherApp.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _repo;

        /// <summary>
        /// City service injected with city repository
        /// </summary>
        /// <param name="repo"></param>
        public CityService(ICityRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Get list of cities for the country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public List<City> GetCities(string country)
        {
            try
            {
                var citiesList = _repo.GetCities(country);
                var cities = citiesList.Select(item => new City
                {
                    Name = item.Name,
                    Country = item.Country
                }).ToList();

                return cities;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
