using AutoServiceShop.Business.Processor.Converter.Encryption;
using AutoServiceShop.Business.Processor.Converter.Session;
using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Business.Processor.Session;
using AutoServiceShop.Business.Processor.User;
using AutoServiceShop.Dataaccess.Dao.User;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.OutProcessor
{
    public class AuthProcessor : IAuthProcessor
    {
        private readonly IsessionProcessor _sessionProcessor;
        private readonly IUserProcessor _userProcessor;

        public AuthProcessor(IsessionProcessor sessionProcessor, IUserProcessor userProcessor)
        {
            _sessionProcessor = sessionProcessor;
            _userProcessor = userProcessor;
        }

        public SessionResult CreateSession(HttpContext httpContext)
        {
            var authenticationValues = AuthenticationHeaderValue.Parse(httpContext.Request.Headers["Authorization"]);

            var bytes = System.Convert.FromBase64String(authenticationValues.Parameter);

            string[] credentials = Encoding.UTF8.GetString(bytes).Split(":");
            string username = credentials[0];

            UserResult result = _userProcessor.Find("Username", username).FirstOrDefault();

            SessionParam param = new SessionParam
            {
                Name = result.Username,
                Active = result.Active,
                Description = DateTime.Now.ToString(),
                UserId = result.Id,
                Token = Encryptor.StringGen()
            };

            return _sessionProcessor.CreateSession(httpContext, param);
        }

        public void RemoveSession(HttpContext httpContext)
        {
            var authenticationValues = AuthenticationHeaderValue.Parse(httpContext.Request.Headers["AuthToken"]);

            string[] token = authenticationValues.ToString().Split(" ");

            SessionResult result = _sessionProcessor.FindSession(token[1]);

            SessionParam param = new SessionParam
            {
                Id = result.Id,
                Token = token[1]
            };

            _sessionProcessor.RemoveSession(httpContext, param);
        }
    }
}
