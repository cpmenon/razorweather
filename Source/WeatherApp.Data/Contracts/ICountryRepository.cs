using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Data.Models;

namespace WeatherApp.Data.Contracts
{
    public interface ICountryRepository
    {
        CountryList GetCountries();
        bool CheckCountryExist(string country);
    }
}
