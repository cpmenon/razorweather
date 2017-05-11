using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using WeatherApp.Data.Contracts;
using WeatherApp.Data.Repository;

namespace WeatherApp.Data
{
    public class DataBootstrapper
    {
        public void Bootstrap(ContainerBuilder builder)
        {
            builder.RegisterType<CountryRepository>().As<ICountryRepository>().SingleInstance();
            builder.RegisterType<WeatherRepository>().As<IWeatherRepository>().SingleInstance();
            builder.RegisterType<CityRepository>().As<ICityRepository>().SingleInstance();
        }
    }
}
