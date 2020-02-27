using AutoServiceShop.Business.Processor.Converter.Session;
using AutoServiceShop.Business.Processor.Converter.User;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AutoServiceShop.Handlers.Providers
{
    public interface IAuthenticationProvider
    {
        public abstract UserResult Authenticate(HttpContext httpContext);

        UserResult AuthenticateById(long id);

        List<string> Authorize(UserResult user);
    }
}
