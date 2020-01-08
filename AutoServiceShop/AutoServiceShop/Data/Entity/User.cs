using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    public class User : Persistent
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
