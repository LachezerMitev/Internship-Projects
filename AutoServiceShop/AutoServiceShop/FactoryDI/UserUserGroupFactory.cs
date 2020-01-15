using Autofac;
using AutoServiceShop.Business.Processor.Converter.UserUserGroup;
using AutoServiceShop.Business.Processor.UserUserGroup;
using AutoServiceShop.Dataaccess.Dao.UserUserGroup;
using AutoServiceShop.Presentation.service.UserUserGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class UserUserGroupFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static IUserUserGroupService ResolveEF()
        {
            Builder();

            builder.RegisterType<UserUserGroupDaoEF>().As<IUserUserGroupDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IUserUserGroupService>();

                return service;
            }
        }

        public static IUserUserGroupService ResolveFile()
        {
            Builder();

            builder.RegisterType<UserUserGroupDaoFile>().As<IUserUserGroupDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IUserUserGroupService>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<UserUserGroupService>().As<IUserUserGroupService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<UserUserGroupProcessor>().As<IUserUserGroupProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<UserUserGroupParamConverter>().As<IUserUserGroupParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<UserUserGroupResultConverter>().As<IUserUserGroupResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
