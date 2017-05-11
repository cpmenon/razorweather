using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp.Data.Models
{
    public class CountryEntity
    {
        public CountryEntity(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

    public class CountryList
    {
        /// <summary>
        /// In-memory country list model
        /// </summary>
        public CountryList()
        {
            Items = new List<CountryEntity>
            {
                new CountryEntity("Australia")
            };

        }
        public List<CountryEntity> Items { get; set; }
    }
}
