using AutoServiceShop.Business.Processor.Converter.Session;
using AutoServiceShop.Data.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Session
{
    public interface IsessionProcessor
    {
        public SessionResult CreateSession(HttpContext httpContext, SessionParam param);

        public SessionResult FindSession(string token);

        public void RemoveSession(HttpContext httpContext , SessionParam param);

        public List<SessionResult> GetSessions();
    }
}
