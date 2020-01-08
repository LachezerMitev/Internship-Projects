using Autofac;
using AutoServiceShop.Business.Processor.AccountStatus;
using AutoServiceShop.Business.Processor.Converter.AccountStatus;
using AutoServiceShop.Dataaccess.Dao.AccountStatus;
using AutoServiceShop.Presentation.service.AccountStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI.Account
{
    public static class AccountStatusFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static IAccountStatusService ResolveEF()
        {
            Builder();

            builder.RegisterType<AccountStatusDaoEF>().As<IAccountStatusDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IAccountStatusService>();

                return service;
            }
        }

        public static IAccountStatusService ResolveFile()
        {
            Builder();

            builder.RegisterType<AccountStatusDaoFile>().As<IAccountStatusDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IAccountStatusService>();

                return service;
            }
        }

        private static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<AccountStatusService>().As<IAccountStatusService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<AccountStatusProcessor>().As<IAccountStatusProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<AccountStatusParamConvert>().As<IAccountStatusParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<AccountStatusResultConvert>().As<IAccountStatusResultConvert>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
