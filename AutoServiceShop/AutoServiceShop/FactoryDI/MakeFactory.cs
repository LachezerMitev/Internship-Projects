using Autofac;
using AutoServiceShop.Business.Processor.Converter.Make;
using AutoServiceShop.Business.Processor.Make;
using AutoServiceShop.Dataaccess.Dao.Make;
using AutoServiceShop.Presentation.service.Make;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class MakeFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static Data.Entity.Make ResolveEF()
        {
            Builder();

            builder.RegisterType<MakeDaoEF>().As<IMakeDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<Data.Entity.Make>();

                return service;
            }
        }

        public static Data.Entity.Make ResolveFile()
        {
            Builder();

            builder.RegisterType<MakeDaoFile>().As<IMakeDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<Data.Entity.Make>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<MakeService>().As<IMakeService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<MakeProcessor>().As<IMakeProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<MakeParamConverter>().As<IMakeParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<MakeResultConverter>().As<IMakeResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
