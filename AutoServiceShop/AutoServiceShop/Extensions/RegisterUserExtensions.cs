using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Business.Processor.User;
using AutoServiceShop.Controllers.UserController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.User;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterUserExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IUserController, UserController>();
            services.AddTransient<IUserProcessor, UserProcessor>();

            if (useDB)
            {
                services.AddTransient<IUserDao, UserDaoEF>();
                services.AddTransient<AutoServiceShopContext>();
            }
            else
                services.AddTransient<IUserDao, UserDaoFile>();

            services.AddTransient<IUserParamConverter, UserParamConverter>();
            services.AddTransient<IUserResultConverter, UserResultConverter>();
        }
    }
}
