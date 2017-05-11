using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using WeatherApp.Services.Contracts;

namespace WeatherApp.Services
{
    public class ServiceBootstrapper
    {
        public void Bootstrap(ContainerBuilder builder)
        {
            builder.RegisterType<CityService>().As<ICityService>().SingleInstance();
            builder.RegisterType<WeatherService>().As<IWeatherService>().SingleInstance();
            builder.RegisterType<CountryService>().As<ICountryService>().SingleInstance();
        }
    }
}
