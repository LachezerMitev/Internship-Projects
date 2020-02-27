using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.AuthorizationAttributes.Controllers
{
    public class AuthorizationCheckUpStatus : AuthorizeAttribute
    {
        public AuthorizationCheckUpStatus()
        {
            Roles = Startup.StaticConfig.GetSection("AuthorizationControllers").GetSection("CheckUpStatus").Value;
        }
    }
}
