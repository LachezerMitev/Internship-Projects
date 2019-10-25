using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.VehicleMakeModel
{
    class VehicleMakeModelParam : BaseParamNamed
    {
        public Data.Entity.Vehicle Vehicle { get; set; }

        public Data.Entity.Make Make { get; set; }

        public Data.Entity.Model ModelList { get; set; }
    }
}
