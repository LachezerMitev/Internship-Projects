using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.VehicleMakeModel
{
    class VehicleMakeModelResultConverter : IVehicleMakeModelResultConverter
    {
        public VehicleMakeModelResult Convert(Data.Entity.VehicleMakeModel param)
        {
<<<<<<< Updated upstream
            VehicleMakeModelResult result = new VehicleMakeModelResult()
            {
                Id = param.Id,

                VehicleId = param.Vehicle.Id,
                VehicleName = param.Vehicle.Name,
=======
            if (param.Vehicle == null || param.Model == null || param.Make == null)
                throw new Exception("Some or all items in the entity taht are crucial were not found");

            result.VehicleId = param.Vehicle.Id;
            result.VehicleName = param.Vehicle.Name;
>>>>>>> Stashed changes

                Modelid = param.Model.Id,
                ModelName = param.Model.Name,

                MakeId = param.Make.Id,
                MakeName = param.Make.Name
            };

            return result;
        }
    }
}
