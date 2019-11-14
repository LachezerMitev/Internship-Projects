using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.VehicleStatus
{
    class VehicleStatusResultConverter : BaseResultConverter<Data.Entity.VehicleStatus, VehicleStatusResult>, IVehicleStatusResultConverter
    {
        public VehicleStatusResult Convert(Data.Entity.VehicleStatus param)
        {
            VehicleStatusResult result = new VehicleStatusResult();

            ConverterStandart(param, result);

            return result;
        }

        public override VehicleStatusResult ConvertSpecific(Data.Entity.VehicleStatus param, VehicleStatusResult result)
        {
            throw new NotImplementedException();
        }
    }
}
