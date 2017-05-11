using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Data.Contracts;
using WeatherApp.Services.Contracts;

namespace WeatherApp.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _repo;

        public CountryService(ICountryRepository repo)
        {
            _repo = repo;
        }
        
        /// <summary>
        /// Check if the country user has typed in exists in datastore
        /// </summary>
        /// <param name="country">Country Name</param>
        /// <returns></returns>
        public bool CheckCountryExists(string country)
        {
            try
            {
                return _repo.CheckCountryExist(country);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
