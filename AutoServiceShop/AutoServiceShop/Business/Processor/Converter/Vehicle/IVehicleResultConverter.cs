using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Vehicle
{
    interface IVehicleResultConverter
    {
        VehicleResult Convert(AutoServiceShop.Data.Entity.Vehicle param);
    }
}
