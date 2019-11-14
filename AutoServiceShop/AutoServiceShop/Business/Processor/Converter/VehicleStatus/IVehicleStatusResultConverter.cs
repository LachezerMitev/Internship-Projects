using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.VehicleStatus
{
    interface IVehicleStatusResultConverter
    {
        VehicleStatusResult Convert(AutoServiceShop.Data.Entity.VehicleStatus param);
    }
}
