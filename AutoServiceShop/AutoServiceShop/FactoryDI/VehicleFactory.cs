using Autofac;
using AutoServiceShop.Business.Processor.Converter.Vehicle;
using AutoServiceShop.Business.Processor.Vehicle;
using AutoServiceShop.Dataaccess.Dao.Vehicle;
using AutoServiceShop.Presentation.service.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class VehicleFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static IVehicleService ResolveEF()
        {
            Builder();

            builder.RegisterType<VehicleDaoEF>().As<IVehicleDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IVehicleService>();

                return service;
            }
        }

        public static IVehicleService ResolveFile()
        {
            Builder();

            builder.RegisterType<VehicleDaoFile>().As<IVehicleDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IVehicleService>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<VehicleService>().As<IVehicleService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<VehicleProcessor>().As<IVehicleProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<VehicleParamConverter>().As<IVehicleParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<VehicleResultConverter>().As<IVehicleResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
