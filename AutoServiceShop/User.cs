using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop
{
    class User : Persistent
    {
        string Username { get; set; }
        string Password { get; set; }
    }
}
