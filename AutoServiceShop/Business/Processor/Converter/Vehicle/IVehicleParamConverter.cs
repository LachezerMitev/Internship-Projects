using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Vehicle
{
    interface IVehicleParamConverter
    {
        AutoServiceShop.Data.Entity.Vehicle Convert(VehicleParam param);
    }
}
