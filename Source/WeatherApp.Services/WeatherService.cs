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
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository _repo;

        /// <summary>
        /// Dependency for weather repository injected
        /// </summary>
        /// <param name="repo"></param>
        public WeatherService(IWeatherRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Gets weather for the city
        /// </summary>
        /// <param name="city">City name</param>
        /// <returns>Returns weather object for city</returns>
        public Weather GetWeather(string city)
        {
            try
            {
                var result = _repo.GetWeather(city);

                if (result == null)
                    return null;

                return new Weather
                {
                    City = result.City,
                    Time = result.Time,
                    Visibility = result.Visibility,
                    Wind = result.Wind,
                    Pressure = result.Pressure,
                    SkyConditions = result.SkyConditions,
                    Temperature = result.Temperature,
                    DewPoint = result.DewPoint,
                    RelativeHumidity = result.RelativeHumidity
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
