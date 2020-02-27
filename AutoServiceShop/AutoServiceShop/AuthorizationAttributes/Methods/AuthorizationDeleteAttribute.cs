using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.AuthorizationAttributes
{
    public class AuthorizationDelete : AuthorizeAttribute
    {
        public AuthorizationDelete()
        {
            Roles = Startup.StaticConfig.GetSection("AuthorizationMethods").GetSection("Delete").Value;
        }
    }
}
