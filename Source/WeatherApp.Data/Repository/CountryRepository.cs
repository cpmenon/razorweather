using System;
using WeatherApp.Data.Contracts;
using WeatherApp.Data.Models;

namespace WeatherApp.Data.Repository
{
    public class CountryRepository : ICountryRepository
    {
        /// <summary>
        ///     Constructor method loading country list to the property model
        /// </summary>
        public CountryRepository()
        {
            Countries = new CountryList();
        }

        private CountryList Countries { get; }

        /// <summary>
        ///     Returns a list of all countries from the in-memory country list model
        /// </summary>
        /// <returns></returns>
        public CountryList GetCountries()
        {
            return Countries;
        }

        /// <summary>
        ///     Check if country exists in the in-memory country list model
        /// </summary>
        /// <param name="country">Country name</param>
        /// <returns>true/false</returns>
        public bool CheckCountryExist(string country)
        {
            try
            {
                var exists =
                    Countries.Items.Exists(
                        x => string.Equals(x.Name, country, StringComparison.CurrentCultureIgnoreCase));
                return exists;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}