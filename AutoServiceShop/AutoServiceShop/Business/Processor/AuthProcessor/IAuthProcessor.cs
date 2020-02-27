using AutoServiceShop.Business.Processor.Converter.Session;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.OutProcessor
{
    public interface IAuthProcessor
    {
        public SessionResult CreateSession(HttpContext httpContext);

        public void RemoveSession(HttpContext httpContext);

    }
}
