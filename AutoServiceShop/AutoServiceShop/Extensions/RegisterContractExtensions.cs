using AutoServiceShop.Business.Processor.Contract;
using AutoServiceShop.Business.Processor.Converter.CheckUp;
using AutoServiceShop.Business.Processor.Converter.Contract;
using AutoServiceShop.Controllers.ContractController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.Contract;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using AutoServiceShop.Dataaccess.Dao.ContractType;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterContractExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IContractController, ContractController>();
            services.AddTransient<IContractProcessor, ContractProcessor>();

            if (useDB)
            {
                services.AddTransient<AutoServiceShopContext>();
                services.AddTransient<IContractDao, ContractDaoEF>();
                services.AddTransient<IContractStatusDao, ContractStatusDaoEF>();
                services.AddTransient<IContractTypeDao, ContractTypeDaoEF>();
            }
            else
            {
                services.AddTransient<IContractDao, ContractDaoFile>();
                services.AddTransient<IContractStatusDao, ContractStatusDaoFile>();
                services.AddTransient<IContractTypeDao, ContractTypeDaoFile>();
            }

            services.AddTransient<IContractParamconverter, ContractParamConverter>();
            services.AddTransient<IContractResultConverter, ContractResultConverter>();
        }
    }
}
