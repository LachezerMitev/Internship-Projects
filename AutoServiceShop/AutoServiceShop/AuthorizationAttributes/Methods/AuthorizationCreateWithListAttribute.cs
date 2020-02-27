using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.AuthorizationAttributes
{
    public class AuthorizationCreateWithList : AuthorizeAttribute
    {
        public AuthorizationCreateWithList()
        {
            Roles = Startup.StaticConfig.GetSection("AuthorizationMethods").GetSection("CreateWithList").Value;
        }
    }
}
