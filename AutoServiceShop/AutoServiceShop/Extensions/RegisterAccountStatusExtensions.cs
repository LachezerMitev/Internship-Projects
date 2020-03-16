using AutoServiceShop.Business.Processor.AccountStatus;
using AutoServiceShop.Business.Processor.Converter.AccountStatus;
using AutoServiceShop.Controllers.AccountStatusController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.AccountStatus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterAccountStatusExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IAccountStatusController, AccountStatusController>();
            services.AddTransient<IAccountStatusProcessor, AccountStatusProcessor>();

            if (useDB)
            {
                services.AddTransient<AutoServiceShopContext>();
                services.AddTransient<IAccountStatusDao, AccountStatusDaoEF>();
            }
                
            else
                services.AddTransient<IAccountStatusDao, AccountStatusDaoFile>();

            services.AddTransient<IAccountStatusResultConvert, AccountStatusResultConvert>();
            services.AddTransient<IAccountStatusParamConverter, AccountStatusParamConvert>();
        }
    }
}
