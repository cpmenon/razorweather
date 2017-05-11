using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Data.Models
{
    public class WeatherEntity
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

    public class WeatherList
    {
        /// <summary>
        /// In-memory weather list model
        /// </summary>
        public WeatherList()
        {
            Items = new List<WeatherEntity>
            {
                new WeatherEntity()
                {
                    City = "Sydney",
                    Time = DateTime.Now,
                    Visibility = "Clear",
                    Wind = 18.4m,
                    SkyConditions = "Rainy",
                    Temperature = 23.3m,
                    DewPoint = 43.05m,
                    RelativeHumidity = 92,
                    Pressure = 1020.4m
                },
                new WeatherEntity()
                {
                    City = "Melbourne",
                    Time = DateTime.Now,
                    Visibility = "Clear",
                    Wind = 18.4m,
                    SkyConditions = "Cloudy",
                    Temperature = .3m,
                    DewPoint = 34.05m,
                    RelativeHumidity = 81,
                    Pressure = 920.68m
                },
                new WeatherEntity()
                {
                    City = "Perth",
                    Time = DateTime.Now,
                    Visibility = "Clear",
                    Wind = 7.8m,
                    SkyConditions = "Sunny",
                    Temperature = 18.3m,
                    DewPoint = 44.05m,
                    RelativeHumidity = 110,
                    Pressure = 821
                },
                new WeatherEntity()
                {
                    City = "Adelaide",
                    Time = DateTime.Now,
                    Visibility = "Clear",
                    Wind = 7.8m,
                    SkyConditions = "Sunny",
                    Temperature = 15.6m,
                    DewPoint = 31.6m,
                    RelativeHumidity = 91,
                    Pressure = 888.6m
                },
                new WeatherEntity()
                {
                    City = "Canberra",
                    Time = DateTime.Now,
                    Visibility = "Partially Clear",
                    Wind = 27.8m,
                    SkyConditions = "Cloudy / Windy",
                    Temperature = 12.6m,
                    DewPoint = 31.6m,
                    RelativeHumidity = 94,
                    Pressure = 888.6m
                },
                new WeatherEntity()
                {
                    City = "Brisbane",
                    Time = DateTime.Now,
                    Visibility = "Sunny and Clear",
                    Wind = 22.8m,
                    SkyConditions = "Clear",
                    Temperature = 16.6m,
                    DewPoint = 29.6m,
                    RelativeHumidity = 94,
                    Pressure = 488.6m
                },
            };
        }
        public List<WeatherEntity> Items { get; set; }
    }
}