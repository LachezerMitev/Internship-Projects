using AutoServiceShop.Business.Processor.Converter.UserUserGroup;
using AutoServiceShop.Business.Processor.UserUserGroup;
using AutoServiceShop.Controllers.UserUserGroupController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.User;
using AutoServiceShop.Dataaccess.Dao.UserGroup;
using AutoServiceShop.Dataaccess.Dao.UserUserGroup;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterUserUserGroupExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IUserUserGroupController, UserUserGroupController>();
            services.AddTransient<IUserUserGroupProcessor, UserUserGroupProcessor>();

            if (useDB)
            {
                services.AddTransient<AutoServiceShopContext>();
                services.AddTransient<IUserUserGroupDao, UserUserGroupDaoEF>();
                services.AddTransient<IUserDao, UserDaoEF>();
                services.AddTransient<IUserGroupDao, UserGroupDaoEF>();
            }
            else
            {
                services.AddTransient<IUserGroupDao, UserGroupDaoFile>();
                services.AddTransient<IUserDao, UserDaoFile>();
                services.AddTransient<IUserUserGroupDao, UserUserGroupDaoFile>();
            }

            services.AddTransient<IUserUserGroupParamConverter, UserUserGroupParamConverter>();
            services.AddTransient<IUserUserGroupResultConverter, UserUserGroupResultConverter>();
        }
    }
}
