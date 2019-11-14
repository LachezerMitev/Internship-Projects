using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.VehicleMakeModel
{
    class VehicleMakeModelResultConverter : BaseResultConverter<Data.Entity.VehicleMakeModel, VehicleMakeModelResult>, IVehicleMakeModelResultConverter
    {
        public VehicleMakeModelResult Convert(Data.Entity.VehicleMakeModel param)
        {
            VehicleMakeModelResult result = new VehicleMakeModelResult();

            ConverterStandart(param, result);

            ConvertSpecific(param, result);

            return result;
        }

        public override VehicleMakeModelResult ConvertSpecific(Data.Entity.VehicleMakeModel param, VehicleMakeModelResult result)
        {
            result.VehicleId = param.Vehicle.Id;
            result.VehicleName = param.Vehicle.Name;

            result.Modelid = param.Model.Id;
            result.ModelName = param.Model.Name;

            result.MakeId = param.Make.Id;
            result.MakeName = param.Make.Name;

            return result;
        }
    }
}
