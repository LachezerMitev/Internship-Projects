using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class NamedPersistent : Persistent
    {
        int Code { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}
