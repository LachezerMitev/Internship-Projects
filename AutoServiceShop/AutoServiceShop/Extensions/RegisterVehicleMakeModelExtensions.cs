using AutoServiceShop.Business.Processor.Converter.VehicleMakeModel;
using AutoServiceShop.Business.Processor.VehicleMakeModel;
using AutoServiceShop.Controllers.VehicleMakeModelController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.Make;
using AutoServiceShop.Dataaccess.Dao.Model;
using AutoServiceShop.Dataaccess.Dao.Vehicle;
using AutoServiceShop.Dataaccess.Dao.VehicleMakeModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterVehicleMakeModelExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IVehicleMakeModelController, VehicleMakeModelController>();
            services.AddTransient<IVehicleMakeModelProcessor, VehicleMakeModelProcessor>();

            if (useDB)
            {
                services.AddTransient<AutoServiceShopContext>();
                services.AddTransient<IVehicleMakeModelDao, VehicleMakeModelDaoEF>();
                services.AddTransient<IVehicleDao, VehicleDaoEF>();
                services.AddTransient<IMakeDao, MakeDaoEF>();
                services.AddTransient<IModelDao, ModelDaoEF>();
            }
            else
            {
                services.AddTransient<IModelDao, ModelDaoFile>();
                services.AddTransient<IMakeDao, MakeDaoFile>();
                services.AddTransient<IVehicleDao, VehicleDaoFile>();
                services.AddTransient<IVehicleMakeModelDao, VehicleMakeModelDaoFile>();
            }
            
            services.AddTransient<IVehicleMakeModelParamConverter, VehicleMakeModelParamConverter>();
            services.AddTransient<IVehicleMakeModelResultConverter, VehicleMakeModelResultConverter>();
        }
    }
}
