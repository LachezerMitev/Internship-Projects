using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.VehicleMakeModel
{
    class VehicleMakeModelParam : BaseParam
    {
        
        public long VehicleId { get; set; }
        public string VehicleName { get; set; }

        public long MakeId { get; set; }
        public string MakeName { get; set; }

        public long Modelid { get; set; }
        public long ModelName { get; set; }
    }
}
