using Autofac;
using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;
using AutoServiceShop.Business.Processor.UserGroupStatus;
using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;
using AutoServiceShop.Presentation.service.UserGroupStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class UserGroupStatusFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static IUserGroupStatusService ResolveEF()
        {
            Builder();

            builder.RegisterType<UserGroupStatusDaoEF>().As<IUserGroupStatusDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IUserGroupStatusService>();

                return service;
            }
        }

        public static IUserGroupStatusService ResolveFile()
        {
            Builder();

            builder.RegisterType<UserGroupStatusDaoFile>().As<IUserGroupStatusDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IUserGroupStatusService>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<UserGroupStatusService>().As<IUserGroupStatusService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<UserGroupStatusProcessor>().As<IUserGroupStatusProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<UserGroupStatusParamConverter>().As<IUserGroupStatusParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<UserGroupStatusResultConverter>().As<IUserGroupStatusResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
