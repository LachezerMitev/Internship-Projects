using AutoServiceShop.Business.Processor.Converter.Issue;
using AutoServiceShop.Business.Processor.Issue;
using AutoServiceShop.Controllers.IssueController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.CheckUp;
using AutoServiceShop.Dataaccess.Dao.Issue;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterIssueExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IIssueController, IssueController>();
            services.AddTransient<IIssueProcessor, IssueProcessor>();

            if (useDB)
            {
                services.AddTransient<AutoServiceShopContext>();
                services.AddTransient<IIssueDao, IssueDaoEF>();
                services.AddTransient<ICheckUpDao, CheckUpDaoEF>();
            }
            else
            {
                services.AddTransient<IIssueDao, IssueDaoFile>();
                services.AddTransient<ICheckUpDao, CheckUpDaoFile>();
            }

            services.AddTransient<IIssueParamConverter, IssueParamConverter>();
            services.AddTransient<IIssueResultConverter, IssueResultConverter>();
        }
    }
}
