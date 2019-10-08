using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class Account : NamedPersistent
    {
        string FirstName { get; set; }
        string Surname { get; set; }
        string LastName { get; set; }
        string Type { get; set; }
    }
}
