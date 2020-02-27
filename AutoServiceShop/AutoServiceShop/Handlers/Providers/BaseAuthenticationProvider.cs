using AutoServiceShop.Business.Processor.Converter.Session;
using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Business.Processor.User;
using AutoServiceShop.Business.Processor.UserUserGroup;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AutoServiceShop.Handlers.Providers
{
    public abstract class BaseAuthenticationProvider : IAuthenticationProvider
    {
        private readonly IUserProcessor _userProcessor;

        private readonly IUserUserGroupProcessor _userUserGroupProcessor;

        protected BaseAuthenticationProvider(IUserProcessor userProcessor, IUserUserGroupProcessor userUserGroupProcessor)
        {
            _userProcessor = userProcessor;
            _userUserGroupProcessor = userUserGroupProcessor;
        }

        public abstract UserResult Authenticate(HttpContext httpContext);

        public UserResult AuthenticateById(long id)
        {
            UserResult user = _userProcessor.Find(id);
            return user;
        }

        public List<string> Authorize(UserResult user)
        {
            return _userUserGroupProcessor.Find("UserId", user.Id.ToString()).Select(x => x.UserGroupName).ToList();
        }
    }
}
