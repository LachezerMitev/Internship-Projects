using AutoServiceShop.Business.Processor.Converter.Session;
using AutoServiceShop.Business.Processor.OutProcessor;
using AutoServiceShop.Business.Processor.Session;
using AutoServiceShop.Controllers.IAPISessionController;
using AutoServiceShop.Controllers.OutController;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Dataaccess.Dao.Session;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterLogInExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services)
        {
            services.AddTransient<IAuthController, AuthController>();
            services.AddTransient<IAPISessionController, APISessionController>();

            services.AddTransient<IsessionProcessor, SessionProcessor>();
            services.AddTransient<IAuthProcessor, AuthProcessor>();
            services.AddTransient<AutoServiceShopContext>();
            services.AddTransient<ISessionDao, SessionDao>();

            services.AddTransient<ISessionParamConverter, SessionParamConverter>();
            services.AddTransient<ISessionResultConverter, SessionResultConverter>();
        }
    }
}
