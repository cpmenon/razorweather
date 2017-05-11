using Autofac;
using NLog;
using WeatherApp.Data;
using WeatherApp.Services;

namespace WeatherApp.Web.Services
{
    public interface IBootstrapper
    {
        void Bootstrap(ContainerBuilder containerBuilder);
    }

    public class WeatherBootstrapper : IBootstrapper
    {
        public void Bootstrap(ContainerBuilder builder)
        {
            // Register concrete class for logger as ILogger implementation
            builder.RegisterInstance(LogManager.GetCurrentClassLogger()).As<ILogger>().SingleInstance();

            // Bootstrap data layer
            new DataBootstrapper().Bootstrap(builder);

            // Bootstrap service layer
            new ServiceBootstrapper().Bootstrap(builder);
        }
    }
}