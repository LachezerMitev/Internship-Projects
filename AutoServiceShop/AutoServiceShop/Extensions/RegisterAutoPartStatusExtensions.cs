using AutoServiceShop.Business.Processor.AutoPart;
using AutoServiceShop.Business.Processor.AutoPartStatus;
using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;
using AutoServiceShop.Controllers.AutoPartController;
using AutoServiceShop.Controllers.AutoPartStatusController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.AutoPart;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterAutoPartStatusExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IAutoPartStatusController, AutoPartStatusController>();
            services.AddTransient<IAutoPartStatusProcessor, AutoPartStatusProcessor>();
            if (useDB)
            {
                services.AddTransient<AutoServiceShopContext>();
                services.AddTransient<IAutoPartStatusDao, AutoPartStatusDaoEF>();
            }  
            else
                services.AddTransient<IAutoPartStatusDao, AutoPartStatusDaoFile>();

            services.AddTransient<IAutoPartStatusParamConverter, AutoPartStatusParamConverter>();
            services.AddTransient<IAutoPartStatusResultConverter, AutoPartStatusResultConverter>();
        }
    }
}
