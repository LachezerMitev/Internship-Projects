using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.AuthorizationAttributes.Controllers
{
    public class AuthorizationContractType : AuthorizeAttribute
    {
        public AuthorizationContractType()
        {
            Roles = Startup.StaticConfig.GetSection("AuthorizationControllers").GetSection("ContractType").Value;
        }
    }
}
