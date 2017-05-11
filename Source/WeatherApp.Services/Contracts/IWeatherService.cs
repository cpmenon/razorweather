using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Services.Models;

namespace WeatherApp.Services.Contracts
{
    public interface IWeatherService
    {
        /// <summary>
        /// Get weather for a particular city 
        /// </summary>
        /// <param name="city">City name</param>
        /// <returns>Weather object</returns>
        Weather GetWeather(string city);
    }
}
