using Autofac;
using AutoServiceShop.Business.Processor.CheckUp;
using AutoServiceShop.Business.Processor.Converter.CheckUp;
using AutoServiceShop.Dataaccess.Dao.CheckUp;
using AutoServiceShop.Presentation.service.CheckUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class CheckUpFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static ICheckUpService ResolveEF()
        {
            Builder();

            builder.RegisterType<CheckUpDaoEF>().As<ICheckUpDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<ICheckUpService>();

                return service;
            }
        }

        public static ICheckUpService ResolveFile()
        {
            Builder();

            builder.RegisterType<CheckUpDaoFile>().As<ICheckUpDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<ICheckUpService>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<CheckUpService>().As<ICheckUpService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<CheckUpProcessor>().As<ICheckUpProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<CheckUpParamConverter>().As<ICheckUpParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<CheckUpResultConverter>().As<ICheckUpResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
