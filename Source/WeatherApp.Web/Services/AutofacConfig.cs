using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;


namespace WeatherApp.Web.Services
{
    public class AutofacConfig
    {
        public static IContainer RegisterAutoFac()
        {
            var builder = new ContainerBuilder();

            // Register MVC web dependencies
            AddMvcRegistrations(builder);

            // Bootstrap service dependencies for weather app
            new WeatherBootstrapper().Bootstrap(builder);

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            return container;
        }

        private static void AddMvcRegistrations(ContainerBuilder builder)
        {
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();
        }
    }
}