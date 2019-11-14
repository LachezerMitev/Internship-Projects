using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class AutoPart : NamedPersistent
    {
        public AutoPartStatus AutoPartsStatus { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
