using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop
{
    class VehicleMakeModel : Persistent
    {
        Vehicle Vehicle { get; set; }
        Make Make { get; set; }
        Model ModelList { get; set; }
    }
}
