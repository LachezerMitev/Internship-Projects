using Autofac;
using AutoServiceShop.Business.Processor.Converter.UserGroup;
using AutoServiceShop.Business.Processor.UserGroup;
using AutoServiceShop.Dataaccess.Dao.UserGroup;
using AutoServiceShop.Presentation.service.UserGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class UserGroupFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static Data.Entity.UserGroup ResolveEF()
        {
            Builder();

            builder.RegisterType<UserGroupDaoEF>().As<IUserGroupDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<Data.Entity.UserGroup>();

                return service;
            }
        }

        public static Data.Entity.UserGroup ResolveFile()
        {
            Builder();

            builder.RegisterType<UserGroupDaoFile>().As<IUserGroupDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<Data.Entity.UserGroup>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<UserGroupService>().As<IUserGroupService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<UserGroupProcessor>().As<IUserGroupProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<UserGroupParamConverter>().As<IUserGroupParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<UserGroupResultConverter>().As<IUserGroupResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
