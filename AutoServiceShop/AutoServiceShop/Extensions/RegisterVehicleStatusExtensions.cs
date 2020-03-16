using AutoServiceShop.Business.Processor.Converter.VehicleStatus;
using AutoServiceShop.Business.Processor.VehicleStatus;
using AutoServiceShop.Controllers.VehicleStatusController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.VehicleStatus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterVehicleStatusExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IVehicleStatusController, VehicleStatusController>();
            services.AddTransient<IVehicleStatusProcessor, VehicleStatusProcessor>();

            if (useDB)
            {
                services.AddTransient<AutoServiceShopContext>();
                services.AddTransient<IVehicleStatusDao, VehicleStatusDaoEF>();
            }
            else
                services.AddTransient<IVehicleStatusDao, VehicleStatusDaoFile>();

            services.AddTransient<IVehicleStatusParamConverter, VehicleStatusParamConverter>();
            services.AddTransient<IVehicleStatusResultConverter, VehicleStatusResultConverter>();
        }
    }
}
