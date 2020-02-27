using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.AuthorizationAttributes
{
    public class AuthorizationFindByField : AuthorizeAttribute
    {
        public AuthorizationFindByField()
        {
            Roles = Startup.StaticConfig.GetSection("AuthorizationMethods").GetSection("FindByField").Value;
        }
    }
}
