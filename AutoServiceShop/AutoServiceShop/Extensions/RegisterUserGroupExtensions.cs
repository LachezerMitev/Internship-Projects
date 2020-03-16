using AutoServiceShop.Business.Processor.Converter.UserGroup;
using AutoServiceShop.Business.Processor.UserGroup;
using AutoServiceShop.Controllers.UserGroupController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.UserGroup;
using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterUserGroupExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IUserGroupController, UserGroupController>();
            services.AddTransient<IUserGroupProcessor, UserGroupProcessor>();

            if (useDB)
            {
                services.AddTransient<AutoServiceShopContext>();
                services.AddTransient<IUserGroupDao, UserGroupDaoEF>();
                services.AddTransient<IUserGroupStatusDao, UserGroupStatusDaoEF>();
            }
            else
            {
                services.AddTransient<IUserGroupDao, UserGroupDaoFile>();
                services.AddTransient<IUserGroupStatusDao, UserGroupStatusDaoFile>();
            }

            services.AddTransient<IUserGroupParamConverter, UserGroupParamConverter>();
            services.AddTransient<IUserGroupResultConverter, UserGroupResultConverter>();
        }
    }
}
