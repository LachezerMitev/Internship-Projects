using AutoServiceShop.Business.Processor.Converter.Encryption;
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
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Handlers.Providers
{
    public class UserAuthenticationProvider : BaseAuthenticationProvider, IAuthenticationProvider
    {
        private readonly IUserProcessor _userProcessor;

        public UserAuthenticationProvider(IUserProcessor userProcessor, IUserUserGroupProcessor userUserGroupProcessor)
            : base(userProcessor, userUserGroupProcessor)
        {
            _userProcessor = userProcessor;
        }
        public override UserResult Authenticate(HttpContext httpContext)
        {
            if (httpContext.Request.Headers.ContainsKey("Authorization"))
            {
                var authenticationValues = AuthenticationHeaderValue.Parse(httpContext.Request.Headers["Authorization"]);

                var bytes = Convert.FromBase64String(authenticationValues.Parameter);

                string[] credentials = Encoding.UTF8.GetString(bytes).Split(":");
                string username = credentials[0];
                string password = credentials[1];

                UserResult user = _userProcessor.Find("Username", username).FirstOrDefault();

                password = Encryptor.SHA512(password);

                if (user.Password != password)
                    return null;
                return user;
            }
            else
                return null;
        }
    }
}
