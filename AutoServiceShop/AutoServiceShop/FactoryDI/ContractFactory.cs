using Autofac;
using AutoServiceShop.Business.Processor.Contract;
using AutoServiceShop.Business.Processor.Converter.Contract;
using AutoServiceShop.Dataaccess.Dao.Contract;
using AutoServiceShop.Presentation.service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class ContractFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static IContractService ResolveEF()
        {
            Builder();

            builder.RegisterType<ContractDaoEF>().As<IContractDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IContractService>();

                return service;
            }
        }

        public static IContractService ResolveFile()
        {
            Builder();

            builder.RegisterType<ContractDaoFile>().As<IContractDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IContractService>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<ContractService>().As<IContractService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<ContractProcessor>().As<IContractProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<ContractParamConverter>().As<IContractParamconverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<ContractResultConverter>().As<IContractResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
