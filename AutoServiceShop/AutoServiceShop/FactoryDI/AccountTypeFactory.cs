using Autofac;
using AutoServiceShop.Business.Processor.AccountType;
using AutoServiceShop.Business.Processor.Converter.AccountType;
using AutoServiceShop.Dataaccess.Dao.AccountType;
using AutoServiceShop.Presentation.service.AccountType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class AccountTypeFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static IAccountTypeService ResolveEF()
        {
            Builder();

            builder.RegisterType<AccountTypeDaoEF>().As<IAccountTypeDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IAccountTypeService>();

                return service;
            }
        }

        public static IAccountTypeService ResolveFile()
        {
            Builder();

            builder.RegisterType<AccountTypeDaoFile>().As<IAccountTypeDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IAccountTypeService>();

                return service;
            }
        }

        private static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<AccountTypeService>().As<IAccountTypeService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<AccountTypeProcessor>().As<IAccountTypeProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<AccountTypeParamConvert>().As<IAccountTypeParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<AccountTypeResultConvert>().As<IAccountTypeResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
