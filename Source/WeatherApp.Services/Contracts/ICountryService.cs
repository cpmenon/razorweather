using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Services.Contracts
{
    public interface ICountryService
    {
        /// <summary>
        /// Check if the country user has typed in exists in datastore
        /// </summary>
        /// <param name="country">Country Name</param>
        /// <returns></returns>
        bool CheckCountryExists(string country);
    }
}
