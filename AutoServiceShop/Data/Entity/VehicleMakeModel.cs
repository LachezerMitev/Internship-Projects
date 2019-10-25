using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class VehicleMakeModel : Persistent
    {
        public Vehicle Vehicle { get; set; }

        public Make Make { get; set; }

        public Model ModelList { get; set; }
    }
}
