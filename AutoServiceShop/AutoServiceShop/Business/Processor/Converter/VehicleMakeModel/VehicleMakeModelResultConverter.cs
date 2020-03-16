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
        public override void ConvertSpecific(Data.Entity.VehicleMakeModel param, VehicleMakeModelResult result)
        {
<<<<<<< Updated upstream
            VehicleMakeModelResult result = new VehicleMakeModelResult()
            {
                Id = param.Id,

                VehicleId = param.Vehicle.Id,
                VehicleName = param.Vehicle.Name,

                Modelid = param.Model.Id,
                ModelName = param.Model.Name,
=======
            if (param.Vehicle == null || param.Model == null || param.Make == null)
                throw new Exception("Some or all items in the entity taht are crucial were not found");

            result.VehicleId = param.Vehicle.Id;
            result.VehicleName = param.Vehicle.Name;
>>>>>>> Stashed changes

            result.Modelid = param.Model.Id;
            result.ModelName = param.Model.Name;

            result.MakeId = param.Make.Id;
            result.MakeName = param.Make.Name;
        }
    }
}
