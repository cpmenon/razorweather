using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Services.Models
{
    public class Weather
    {
        public string City { get; set; }
        public DateTime Time { get; set; }
        public string Visibility { get; set; }
        public decimal Wind { get; set; }
        public string SkyConditions { get; set; }
        public decimal Temperature { get; set; }
        public decimal DewPoint { get; set; }
        public int RelativeHumidity { get; set; }
        public decimal Pressure { get; set; }
    }
}