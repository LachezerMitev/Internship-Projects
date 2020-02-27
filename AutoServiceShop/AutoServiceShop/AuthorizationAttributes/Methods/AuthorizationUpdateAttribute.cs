using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.AuthorizationAttributes
{
    public class AuthorizationUpdate : AuthorizeAttribute
    {
        public AuthorizationUpdate()
        {
            Roles = Startup.StaticConfig.GetSection("AuthorizationMethods").GetSection("Update").Value;
        }
    }
}
