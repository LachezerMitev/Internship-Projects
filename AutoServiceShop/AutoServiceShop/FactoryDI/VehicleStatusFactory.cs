using Autofac;
using AutoServiceShop.Business.Processor.Converter.VehicleStatus;
using AutoServiceShop.Business.Processor.VehicleStatus;
using AutoServiceShop.Dataaccess.Dao.VehicleStatus;
using AutoServiceShop.Presentation.service.VehicleStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class VehicleStatusFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static Data.Entity.VehicleStatus ResolveEF()
        {
            Builder();

            builder.RegisterType<VehicleStatusDaoEF>().As<IVehicleStatusDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<Data.Entity.VehicleStatus>();

                return service;
            }
        }

        public static Data.Entity.VehicleStatus ResolveFile()
        {
            Builder();

            builder.RegisterType<VehicleStatusDaoFile>().As<IVehicleStatusDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<Data.Entity.VehicleStatus>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<VehicleStatusService>().As<IVehicleStatusService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<VehicleStatusProcessor>().As<IVehicleStatusProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<VehicleStatusParamConverter>().As<IVehicleStatusParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<VehicleStatusResultConverter>().As<IVehicleStatusResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
