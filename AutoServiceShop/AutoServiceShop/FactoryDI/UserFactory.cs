using Autofac;
using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Business.Processor.User;
using AutoServiceShop.Dataaccess.Dao.User;
using AutoServiceShop.Presentation.service.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class UserFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static IUserService ResolveEF()
        {
            Builder();

            builder.RegisterType<UserDaoEF>().As<IUserDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IUserService>();

                return service;
            }
        }

        public static IUserService ResolveFile()
        {
            Builder();

            builder.RegisterType<UserDaoFile>().As<IUserDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IUserService>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<UserService>().As<IUserService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<UserProcessor>().As<IUserProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<UserParamConverter>().As<IUserParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<UserResultConverter>().As<IUserResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
