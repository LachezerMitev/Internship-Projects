using AutoServiceShop.Business.Processor.AccountType;
using AutoServiceShop.Business.Processor.Converter.AccountType;
using AutoServiceShop.Controllers.AccountTypeController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.AccountType;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterAccountTypeExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IAccountTypeController, AccountTypeController>();
            services.AddTransient<IAccountTypeProcessor, AccountTypeProcessor>();

            if (useDB)
            {
                services.AddTransient<AutoServiceShopContext>();
                services.AddTransient<IAccountTypeDao, AccountTypeDaoEF>();
            }
                
            else
                services.AddTransient<IAccountTypeDao, AccountTypeDaoFile>();

            services.AddTransient<IAccountTypeParamConverter, AccountTypeParamConvert>();
            services.AddTransient<IAccountTypeResultConverter, AccountTypeResultConvert>();
        }
    }
}
