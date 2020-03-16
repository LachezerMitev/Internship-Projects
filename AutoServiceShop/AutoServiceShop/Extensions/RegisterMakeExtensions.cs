using AutoServiceShop.Business.Processor.Converter.Make;
using AutoServiceShop.Business.Processor.Make;
using AutoServiceShop.Controllers.MakeController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.Make;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterMakeExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IMakeController, MakeController>();
            services.AddTransient<IMakeProcessor, MakeProcessor>();

            if (useDB)
            {
                services.AddTransient<AutoServiceShopContext>();

                services.AddTransient<IMakeDao, MakeDaoEF>();
            }
            else
                services.AddTransient<IMakeDao, MakeDaoFile>();

            services.AddTransient<IMakeParamConverter, MakeParamConverter>();
            services.AddTransient<IMakeResultConverter, MakeResultConverter>();
        }
    }
}
