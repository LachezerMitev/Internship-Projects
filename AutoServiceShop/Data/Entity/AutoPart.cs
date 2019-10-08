using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class AutoPart : NamedPersistent
    {
        AutoPartStatus AutoPartsStatus { get; set; }
        double Price { get; set; }
        int Quantity { get; set; }
    }
}
