using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.AuthorizationAttributes.Controllers
{
    public class AuthorizationVehicle : AuthorizeAttribute
    {
        public AuthorizationVehicle()
        {
            Roles = Startup.StaticConfig.GetSection("AuthorizationControllers").GetSection("Vehicle").Value;
        }
    }
}
