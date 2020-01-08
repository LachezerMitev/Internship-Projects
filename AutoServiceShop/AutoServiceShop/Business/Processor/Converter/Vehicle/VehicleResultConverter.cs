using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Vehicle
{
    class VehicleResultConverter : BaseResultConverter<Data.Entity.Vehicle, VehicleResult>, IVehicleResultConverter
    {
        public override void ConvertSpecific(Data.Entity.Vehicle param, VehicleResult result)
        {
            result.VehicleStatusId = param.VehicleStatus.Id;
            result.VehicleStatusName = param.VehicleStatus.Name;
        }
    }
}
