using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    public class SessionAPI : NamedPersistent
    {
        public long UserId { get; set; }

        public string Token { get; set; }
    }
}
