using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.AuthorizationAttributes
{
    public class AuthorizationListAll : AuthorizeAttribute
    {
        public AuthorizationListAll()
        {
            Roles = Startup.StaticConfig.GetSection("AuthorizationMethods").GetSection("ListAll").Value;
        }
    }
}
