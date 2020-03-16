using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AutoServiceShopClient.Data.Entity
{
    public class SessionAPI : NamedPersistent
    {
        public long UserId { get; set; }

        public string Token { get; set; }
    }
}
