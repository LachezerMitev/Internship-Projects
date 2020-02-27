using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.AuthorizationAttributes
{
    public class AuthorizationCreate : AuthorizeAttribute
    {
        public AuthorizationCreate()
        {
            Roles = Startup.StaticConfig.GetSection("AuthorizationMethods").GetSection("Create").Value;
        }
    }
}
