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
        public VehicleResult Convert(Data.Entity.Vehicle param)
        {
            VehicleResult result = new VehicleResult();

            ConverterStandart(param, result);

            ConvertSpecific(param, result);

            return result;
        }

        public override VehicleResult ConvertSpecific(Data.Entity.Vehicle param, VehicleResult result)
        {
            result.VehicleStatusId = param.VehicleStatus.Id;
            result.VehicleStatusName = param.VehicleStatus.Name;

            result.OwnerId = param.Owner.Id;
            result.OwnerName = param.Owner.Name;

            return result;
        }
    }
}
