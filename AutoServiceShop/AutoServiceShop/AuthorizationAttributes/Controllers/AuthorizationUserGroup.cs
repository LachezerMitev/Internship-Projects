using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.AuthorizationAttributes.Controllers
{
    public class AuthorizationUserGroup : AuthorizeAttribute
    {
        public AuthorizationUserGroup()
        {
            Roles = Startup.StaticConfig.GetSection("AuthorizationControllers").GetSection("UserGroup").Value;
        }
    }
}
