using Autofac;
using AutoServiceShop.Business.Processor.Account;
using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Dataaccess.Dao.Account;
using AutoServiceShop.Dataaccess.Dao.AccountStatus;
using AutoServiceShop.Dataaccess.Dao.AccountType;
using AutoServiceShop.Dataaccess.Dao.User;
using AutoServiceShop.Presentation.service.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI.Account
{
    public static class AccountFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static IAccountService ResolveEF()
        {
            Builder();

            builder.RegisterType<AccountDaoEF>().As<IAccountDao>().PropertiesAutowired();
            builder.RegisterType<AccountStatusDaoEF>().As<IAccountStatusDao>().PropertiesAutowired();
            builder.RegisterType<UserDaoEF>().As<IUserDao>().PropertiesAutowired();
            builder.RegisterType<AccountTypeDaoEF>().As<IAccountTypeDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IAccountService>();

                return service;
            }
        }

        public static IAccountService ResolveFile()
        {
            Builder();

            builder.RegisterType<AccountDaoFile>().As<IAccountDao>().PropertiesAutowired();
            builder.RegisterType<AccountStatusDaoFile>().As<IAccountStatusDao>().PropertiesAutowired();
            builder.RegisterType<UserDaoFile>().As<IUserDao>().PropertiesAutowired();
            builder.RegisterType<AccountTypeDaoFile>().As<IAccountTypeDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IAccountService>();

                return service;
            }
        }

        private static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<AccountService>().As<IAccountService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<AccountProcessor>().As<IAccountProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<AccountParamConverter>().As<IAccountParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<AccountResultConverter>().As<IAccountResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
