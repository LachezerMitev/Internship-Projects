using AutoServiceShop.Business.Processor.CheckUpStatus;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;
using AutoServiceShop.Controllers.CheckUpStatusController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterCheckUpStatusExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<ICheckUpStatusController, CheckUpStatusController>();
            services.AddTransient<ICheckUpStatusProcessor, CheckUpStatusProcessor>();

            if (useDB)
            {
                services.AddTransient<IContractStatusDao, ContractStatusDaoEF>();
                services.AddTransient<AutoServiceShopContext>();
            }  
            else
                services.AddTransient<IContractStatusDao, ContractStatusDaoFile>();

            services.AddTransient<ICheckUpStatusParamConverter, CheckUpStatusParamConverter>();
            services.AddTransient<ICheckUpStatusResultConverter, CheckUpStatusResultConverter>();
        }
    }
}
