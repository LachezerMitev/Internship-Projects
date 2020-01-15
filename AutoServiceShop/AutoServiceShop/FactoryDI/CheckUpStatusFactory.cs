using Autofac;
using AutoServiceShop.Business.Processor.CheckUpStatus;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;
using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;
using AutoServiceShop.Presentation.service.CheckUpStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class CheckUpStatusFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static ICheckUpStatusService ResolveEF()
        {
            Builder();

            builder.RegisterType<CheckUpStatusDaoEF>().As<ICheckUpStatusDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<ICheckUpStatusService>();

                return service;
            }
        }

        public static ICheckUpStatusService ResolveFile()
        {
            Builder();

            builder.RegisterType<CheckUpStatusDaoFile>().As<ICheckUpStatusDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<ICheckUpStatusService>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<CheckUpStatusService>().As<ICheckUpStatusService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<CheckUpStatusProcessor>().As<ICheckUpStatusProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<CheckUpStatusParamConverter>().As<ICheckUpStatusParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<CheckUpStatusResultConverter>().As<ICheckUpStatusResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
