using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class User : Persistent
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
