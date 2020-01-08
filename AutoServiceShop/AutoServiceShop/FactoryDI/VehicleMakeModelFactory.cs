using Autofac;
using AutoServiceShop.Business.Processor.Converter.VehicleMakeModel;
using AutoServiceShop.Business.Processor.VehicleMakeModel;
using AutoServiceShop.Dataaccess.Dao.VehicleMakeModel;
using AutoServiceShop.Presentation.service.VehicleMakeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class VehicleMakeModelFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static Data.Entity.VehicleMakeModel ResolveEF()
        {
            Builder();

            builder.RegisterType<VehicleMakeModelDaoEF>().As<IVehicleMakeModelDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<Data.Entity.VehicleMakeModel>();

                return service;
            }
        }

        public static Data.Entity.VehicleMakeModel ResolveFile()
        {
            Builder();

            builder.RegisterType<VehicleMakeModelDaoFile>().As<IVehicleMakeModelDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<Data.Entity.VehicleMakeModel>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<VehicleMakeModelService>().As<IVehicleMakeModelService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<VehicleMakeModelProcessor>().As<IVehicleMakeModelProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<VehicleMakeModelParamConverter>().As<IVehicleMakeModelParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<VehicleMakeModelResultConverter>().As<IVehicleMakeModelResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
