using System.Linq;
using WeatherApp.Data.Contracts;
using WeatherApp.Data.Models;

namespace WeatherApp.Data.Repository
{
    public class WeatherRepository : IWeatherRepository
    {
        /// <summary>
        ///     Get weather for a city from in-memory weather list model
        /// </summary>
        /// <param name="city">City name</param>
        /// <returns></returns>
        public WeatherEntity GetWeather(string city)
        {
            var list = new WeatherList();
            return list.Items.FirstOrDefault(x => x.City.ToLower() == city.ToLower());
        }
    }
}