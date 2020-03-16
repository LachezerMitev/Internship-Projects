using AutoServiceShop.Business.Processor.ContractType;
using AutoServiceShop.Business.Processor.Converter.ContractType;
using AutoServiceShop.Controllers.ContractTypeController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.ContractType;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterContractTypeExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IContractTypeController, ContractTypeController>();
            services.AddTransient<IContractTypeProcessor, ContractTypeProcessor>();

            if (useDB)
            {
                services.AddTransient<IContractTypeDao, ContractTypeDaoEF>();
                services.AddTransient<AutoServiceShopContext>();
            }
            else
                services.AddTransient<IContractTypeDao, ContractTypeDaoFile>();

            services.AddTransient<IContractTypeParamConverter, ContractTypeParamConverter>();
            services.AddTransient<IContractTypeResultConverter, ContractTypeResultConverter>();
        }
    }
}
