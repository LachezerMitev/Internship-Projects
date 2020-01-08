using Autofac;
using AutoServiceShop.Business.Processor.AutoPart;
using AutoServiceShop.Business.Processor.Converter.AutoPart;
using AutoServiceShop.Dataaccess.Dao.AutoPart;
using AutoServiceShop.Presentation.service.AutoPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class AutoPartFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static IAutoPartService ResolveEF()
        {
            Builder();

            builder.RegisterType<AutoPartDaoEF>().As<IAutoPartDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IAutoPartService>();

                return service;
            }
        }

        public static IAutoPartService ResolveFile()
        {
            Builder();

            builder.RegisterType<AutoPartDaoFile>().As<IAutoPartDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IAutoPartService>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<AutoPartService>().As<IAutoPartService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<AutoPartProcessor>().As<IAutoPartProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<AutoPartParamConverter>().As<IAutoPartParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<AutoPartResultConverter>().As<IAutoPartResultConvert>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
