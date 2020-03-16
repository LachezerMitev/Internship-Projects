using AutoServiceShop.Business.Processor.Converter.Vehicle;
using AutoServiceShop.Business.Processor.Vehicle;
using AutoServiceShop.Controllers.VehicleController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.Vehicle;
using AutoServiceShop.Dataaccess.Dao.VehicleStatus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterVehicleExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IVehicleController, VehicleController>();
            services.AddTransient<IVehicleProcessor, VehicleProcessor>();

            if (useDB)
            {
                services.AddTransient<AutoServiceShopContext>();
                services.AddTransient<IVehicleDao, VehicleDaoEF>();
                services.AddTransient<IVehicleStatusDao, VehicleStatusDaoEF>();
            }
            else
            {
                services.AddTransient<IVehicleDao, VehicleDaoFile>();
                services.AddTransient<IVehicleStatusDao, VehicleStatusDaoFile>();
            }

            services.AddTransient<IVehicleParamConverter, VehicleParamConverter>();
            services.AddTransient<IVehicleResultConverter, VehicleResultConverter>();
        }
    }
}
