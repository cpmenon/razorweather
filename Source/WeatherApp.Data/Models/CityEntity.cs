using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Data.Models
{
    public class CityEntity
    {
        public CityEntity(string name, string country)
        {
            Name = name;
            Country = country;
        }
        public string Name { get; set; }
        public string Country { get; set; }
    }

    public class CityList
    {
        /// <summary>
        /// In-memory city list model
        /// </summary>
        public CityList()
        {
            Items = new List<CityEntity>
            {
                new CityEntity("Sydney", "Australia"),
                new CityEntity("Melbourne", "Australia"),
                new CityEntity("Perth", "Australia"),
                new CityEntity("Canberra", "Australia"),
                new CityEntity("Adelaide", "Australia"),
                new CityEntity("Brisbane", "Australia")
            };
        }

        public List<CityEntity> Items { get; set; }
    }

}
