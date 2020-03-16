using AutoServiceShop.Business.Processor.ContractStatus;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;
using AutoServiceShop.Controllers.ContractStatusController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterContractStatusExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IContractStatusController, ContractStatusController>();
            services.AddTransient<IContractStatusProcessor, ContractStatusProcessor>();

            if (useDB)
            {
                services.AddTransient<IContractStatusDao, ContractStatusDaoEF>();
                services.AddTransient<AutoServiceShopContext>();
            }
            else
                services.AddTransient<IContractStatusDao, ContractStatusDaoFile>();

            services.AddTransient<IContractStatusParamConverter, ContractStatusParamConverter>();
            services.AddTransient<IContractStatusResultConverter, ContractStatusResultConverter>();
        }
    }
}
