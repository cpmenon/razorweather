using System;
using System.Collections.Generic;
using System.Linq;
using WeatherApp.Data.Contracts;
using WeatherApp.Data.Models;

namespace WeatherApp.Data.Repository
{
    public class CityRepository : ICityRepository
    {
        /// <summary>
        ///     Get list of cities from in memory city list model
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public IEnumerable<CityEntity> GetCities(string country)
        {
            try
            {
                var cities = new CityList();
                return cities.Items.Where(x => x.Country.ToLower() == country.ToLower());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}