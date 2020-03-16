using AutoServiceShop.Business.Processor.Converter.Model;
using AutoServiceShop.Business.Processor.Model;
using AutoServiceShop.Controllers.ModelController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterModelExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services, bool useDB)
        {
            services.AddTransient<IModelController, ModelController>();
            services.AddTransient<IModelProcessor, ModelProcessor>();

            if (useDB)
            {
                services.AddTransient<IModelDao, ModelDaoEF>();
                services.AddTransient<AutoServiceShopContext>();
            }
            else
                services.AddTransient<IModelDao, ModelDaoFile>();

            services.AddTransient<IModelParamConverter, ModelParamConverter>();
            services.AddTransient<IModelResultConverter, ModelResultConverrter>();
        }
    }
}
