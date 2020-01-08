using Autofac;
using AutoServiceShop.Business.Processor.Converter.Model;
using AutoServiceShop.Business.Processor.Model;
using AutoServiceShop.Dataaccess.Dao.Model;
using AutoServiceShop.Presentation.service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class ModelFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static Data.Entity.Model ResolveEF()
        {
            Builder();

            builder.RegisterType<ModelDaoEF>().As<IModelDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<Data.Entity.Model>();

                return service;
            }
        }

        public static Data.Entity.Model ResolveFile()
        {
            Builder();

            builder.RegisterType<ModelDaoFile>().As<IModelDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<Data.Entity.Model>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<ModelService>().As<IModelService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<ModelProcessor>().As<IModelProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<ModelParamConverter>().As<IModelParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<ModelResultConverrter>().As<IModelResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
