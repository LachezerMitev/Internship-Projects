using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.VehicleStatus
{
    interface IVehicleStatusParamConverter
    {
        AutoServiceShop.Data.Entity.VehicleStatus Convert(VehicleStatusParam param);
    }
}
