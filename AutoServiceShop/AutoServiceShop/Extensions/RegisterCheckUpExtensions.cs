using AutoServiceShop.Business.Processor.CheckUp;
using AutoServiceShop.Business.Processor.Converter.CheckUp;
using AutoServiceShop.Controllers.CheckUpController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.Account;
using AutoServiceShop.Dataaccess.Dao.CheckUp;
using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;
using AutoServiceShop.Dataaccess.Dao.Contract;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using AutoServiceShop.Dataaccess.Dao.Vehicle;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterCheckUpExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<ICheckUpController, CheckUpController>();
            services.AddTransient<ICheckUpProcessor, CheckUpProcessor>();

            if (useDB)
            {
                services.AddTransient<AutoServiceShopContext>();
                services.AddTransient<ICheckUpDao, CheckUpDaoEF>();
                services.AddTransient<ICheckUpStatusDao, CheckUpStatusDaoEF>();
                services.AddTransient<IAccountDao, AccountDaoEF>();
                services.AddTransient<IVehicleDao, VehicleDaoEF>();
            }
            else
            {
                services.AddTransient<ICheckUpDao, CheckUpDaoFile>();
                services.AddTransient<ICheckUpStatusDao, CheckUpStatusDaoFile>();
                services.AddTransient<IAccountDao, AccountDaoFile>();
                services.AddTransient<IVehicleDao, VehicleDaoFile>();
            }

            services.AddTransient<ICheckUpParamConverter, CheckUpParamConverter>();
            services.AddTransient<ICheckUpResultConverter, CheckUpResultConverter>();
        }
    }
}
