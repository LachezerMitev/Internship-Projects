using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;
using AutoServiceShop.Business.Processor.UserGroupStatus;
using AutoServiceShop.Controllers.UserGroupStatusController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterUserGroupStatusExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IUserGroupStatusController, UserGroupStatusController>();
            services.AddTransient<IUserGroupStatusProcessor, UserGroupStatusProcessor>();

            if (useDB)
            {
                services.AddTransient<IUserGroupStatusDao, UserGroupStatusDaoEF>();
                services.AddTransient<AutoServiceShopContext>();
            }
            else
                services.AddTransient<IUserGroupStatusDao, UserGroupStatusDaoFile>();

            services.AddTransient<IUserGroupStatusParamConverter, UserGroupStatusParamConverter>();
            services.AddTransient<IUserGroupStatusResultConverter, UserGroupStatusResultConverter>();
        }
    }
}
