using AutoServiceShop.Business.Processor.Converter.Session;
using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Business.Processor.Session;
using AutoServiceShop.Business.Processor.User;
using AutoServiceShop.Business.Processor.UserUserGroup;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AutoServiceShop.Handlers.Providers
{
    public class TokenAuthenticationProvider : BaseAuthenticationProvider
    {
        private readonly IsessionProcessor _sessionProcessor;

        public TokenAuthenticationProvider(IsessionProcessor sessionProcessor, IUserProcessor userProcessor, IUserUserGroupProcessor userUserGroupProcessor)
            : base(userProcessor, userUserGroupProcessor)
        {
            _sessionProcessor = sessionProcessor;
        }

        public override UserResult Authenticate(HttpContext httpContext)
        {
            if (httpContext.Request.Headers.ContainsKey("AuthToken"))
            {
                var authenticationValues = AuthenticationHeaderValue.Parse(httpContext.Request.Headers["AuthToken"]);

                string[] Token = authenticationValues.ToString().Split(" ");

                SessionResult sessionResult = _sessionProcessor.FindSession(Token[1]);

                UserResult result = AuthenticateById(sessionResult.UserId);

                if (result == null)
                    return null;
                return result;
            }
            else
                return null;
        }
    }
}
