using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Services.Models;

namespace WeatherApp.Services.Contracts
{
    public interface ICityService
    {
        /// <summary>
        /// Get list of cities for the country
        /// </summary>
        /// <param name="country">Country Name</param>
        /// <returns>List of cities</returns>
        List<City> GetCities(string country);
    }
}