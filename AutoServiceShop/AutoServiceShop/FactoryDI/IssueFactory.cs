using Autofac;
using AutoServiceShop.Business.Processor.Converter.Issue;
using AutoServiceShop.Business.Processor.Issue;
using AutoServiceShop.Dataaccess.Dao.Issue;
using AutoServiceShop.Presentation.service.Issue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.FactoryDI
{
    public static class IssueFactory
    {
        private static ContainerBuilder builder = new ContainerBuilder();

        public static IIssueService ResolveEF()
        {
            Builder();

            builder.RegisterType<IssueDaoEF>().As<IIssueDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IIssueService>();

                return service;
            }
        }

        public static IIssueService ResolveFile()
        {
            Builder();

            builder.RegisterType<IssueDaoFile>().As<IIssueDao>().PropertiesAutowired();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IIssueService>();

                return service;
            }
        }

        public static void Builder()
        {
            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<IssueService>().As<IIssueService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<IssueProcessor>().As<IIssueProcessor>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<IssueParamConverter>().As<IIssueParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<IssueResultConverter>().As<IIssueResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////
        }
    }
}
