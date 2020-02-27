using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.AuthorizationAttributes.Controllers
{
    public class AuthorizationAccountStatus : AuthorizeAttribute
    {
        public AuthorizationAccountStatus()
        {
            Roles = Startup.StaticConfig.GetSection("AuthorizationControllers").GetSection("AccountStatus").Value;
        }
    }
}
