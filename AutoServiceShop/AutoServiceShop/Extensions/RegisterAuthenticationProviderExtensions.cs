using AutoServiceShop.Handlers.Providers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisterAuthenticationProviderExtensions
    {
        public static void RegiserDependencies(this IServiceCollection services)
        {
            services.AddTransient<IAuthenticationProvider, UserAuthenticationProvider>();
            services.AddTransient<IAuthenticationProvider, TokenAuthenticationProvider>();
        }
    }
}
