﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.AuthorizationAttributes
{
    public class AuthorizationFindByPK : AuthorizeAttribute
    {
        public AuthorizationFindByPK()
        {
            Roles = Startup.StaticConfig.GetSection("AuthorizationMethods").GetSection("FindByPK").Value;
        }
    }
}
