using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.AuthorizationAttributes
{
    public class AuthorizationDeleteById : AuthorizeAttribute
    {
        public AuthorizationDeleteById()
        {
            Roles = Startup.StaticConfig.GetSection("AuthorizationMethods").GetSection("DeleteById").Value;
        }
    }
}
