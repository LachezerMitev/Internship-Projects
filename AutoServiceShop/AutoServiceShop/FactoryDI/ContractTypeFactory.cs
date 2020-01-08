using Autofac;
using AutoServiceShop.Business.Processor.ContractType;
using AutoServiceShop.Business.Processor.Converter.ContractType;
using AutoServiceShop.Dataaccess.Dao.ContractType;
using AutoServiceShop.Presentation.service.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class ContractTypeFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static Data.Entity.ContractType ResolveEF()
        {
            Builder();

            builder.RegisterType<ContractTypeDaoEF>().As<IContractTypeDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<Data.Entity.ContractType>();

                return service;
            }
        }

        public static Data.Entity.ContractType ResolveFile()
        {
            Builder();

            builder.RegisterType<ContractTypeDaoFile>().As<IContractTypeDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<Data.Entity.ContractType>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<ContractTypeService>().As<IContractTypeService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<ContractTypeProcessor>().As<IContractTypeProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<ContractTypeParamConverter>().As<IContractTypeParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<ContractTypeResultConverter>().As<IContractTypeResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
