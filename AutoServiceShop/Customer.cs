using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop
{
    class Customer : NamedPersistent
    {
        CustomerStatus CustomerStatus { get; set; }
    }
}
