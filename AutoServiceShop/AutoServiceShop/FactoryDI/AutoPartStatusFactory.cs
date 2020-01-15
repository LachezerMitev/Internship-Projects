using Autofac;
using AutoServiceShop.Business.Processor.AutoPartStatus;
using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;
using AutoServiceShop.Presentation.service.AutoPartStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class AutoPartStatusFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static IAutoPartStatusService ResolveEF()
        {
            Builder();

            builder.RegisterType<AutoPartStatusDaoEF>().As<IAutoPartStatusDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IAutoPartStatusService>();

                return service;
            }
        }

        public static IAutoPartStatusService ResolveFile()
        {
            Builder();

            builder.RegisterType<AutoPartStatusDaoFile>().As<IAutoPartStatusDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IAutoPartStatusService>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<AutoPartStatusService>().As<IAutoPartStatusService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<AutoPartStatusProcessor>().As<IAutoPartStatusProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<AutoPartStatusParamConverter>().As<IAutoPartStatusParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<AutoPartStatusResultConverter>().As<IAutoPartStatusResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
