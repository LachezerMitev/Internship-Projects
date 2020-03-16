using AutoServiceShop.Business.Processor.AutoPart;
using AutoServiceShop.Business.Processor.Converter.AutoPart;
using AutoServiceShop.Controllers.AutoPartController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.AutoPart;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;
using AutoServiceShop.Dataaccess.Dao.CheckUp;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterAutoPartExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IAutoPartController, AutoPartController>();
            services.AddTransient<IAutoPartProcessor, AutoPartProcessor>();

            if (useDB)
            {
                services.AddTransient<IAutoPartStatusDao, AutoPartStatusDaoEF>();
                services.AddTransient<ICheckUpDao, CheckUpDaoEF>();
                services.AddTransient<IAutoPartDao, AutoPartDaoEF>();
                services.AddTransient<AutoServiceShopContext>();
            }
            else
            {
                services.AddTransient<IAutoPartStatusDao, AutoPartStatusDaoFile>();
                services.AddTransient<IAutoPartDao, AutoPartDaoFile>();
                services.AddTransient<ICheckUpDao, CheckUpDaoFile>();
            }

            services.AddTransient<IAutoPartParamConverter, AutoPartParamConverter>();
            services.AddTransient<IAutoPartResultConvert, AutoPartResultConverter>();
        }
    }
}
