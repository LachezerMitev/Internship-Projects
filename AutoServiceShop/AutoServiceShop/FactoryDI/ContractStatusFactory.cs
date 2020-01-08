using Autofac;
using AutoServiceShop.Business.Processor.ContractStatus;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using AutoServiceShop.Presentation.service.ContractStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class ContractStatusFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static Data.Entity.ContractStatus ResolveEF()
        {
            Builder();

            builder.RegisterType<ContractStatusDaoEF>().As<IContractStatusDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<Data.Entity.ContractStatus>();

                return service;
            }
        }

        public static Data.Entity.ContractStatus ResolveFile()
        {
            Builder();

            builder.RegisterType<ContractStatusDaoFile>().As<IContractStatusDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<Data.Entity.ContractStatus>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<ContractStatusService>().As<IContractStatusService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<ContractStatusProcessor>().As<IContractStatusProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<ContractStatusParamConverter>().As<IContractStatusParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<ContractStatusResultConverter>().As<IContractStatusResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
