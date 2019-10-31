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
            VehicleMakeModelResult result = new VehicleMakeModelResult()
            {
                Id = param.Id,

                VehicleId = param.Vehicle.Id,
                VehicleName = param.Vehicle.Name,

                Modelid = param.Model.Id,
                ModelName = param.Model.Name,

                MakeId = param.Make.Id,
                MakeName = param.Make.Name
            };

            return result;
        }
    }
}
