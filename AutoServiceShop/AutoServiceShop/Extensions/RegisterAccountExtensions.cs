using AutoServiceShop.Business.Processor.Account;
using AutoServiceShop.Business.Processor.AccountStatus;
using AutoServiceShop.Business.Processor.AccountType;
using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Business.Processor.User;
using AutoServiceShop.Controllers.AccountController;
using AutoServiceShop.Controllers.AccountStatusController;
using AutoServiceShop.Controllers.AccountTypeController;
using AutoServiceShop.Controllers.UserController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.Account;
using AutoServiceShop.Dataaccess.Dao.AccountStatus;
using AutoServiceShop.Dataaccess.Dao.AccountType;
using AutoServiceShop.Dataaccess.Dao.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterAccountExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IAccountController, AccountController>();

            services.AddTransient<IAccountProcessor, AccountProcessor>();
            if (useDB)
            {
                services.AddTransient<AutoServiceShopContext>();
                services.AddTransient<IAccountDao, AccountDaoEF>();
                services.AddTransient<IAccountStatusDao, AccountStatusDaoEF>();
                services.AddTransient<IAccountTypeDao, AccountTypeDaoEF>();
                services.AddTransient<IUserDao, UserDaoEF>();
            }
            else
            {
                services.AddTransient<IAccountDao, AccountDaoFile>();
                services.AddTransient<IAccountStatusDao, AccountStatusDaoFile>();
                services.AddTransient<IAccountTypeDao, AccountTypeDaoFile>();
                services.AddTransient<IUserDao, UserDaoFile>();
            }

            services.AddTransient<IAccountParamConverter, AccountParamConverter>();
            services.AddTransient<IAccountResultConverter, AccountResultConverter>();
        }
    }
}
