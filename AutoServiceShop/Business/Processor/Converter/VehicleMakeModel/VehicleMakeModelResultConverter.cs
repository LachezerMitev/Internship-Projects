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

                Vehicle = param.Vehicle,
                Make = param.Make,
                ModelList = param.ModelList
            };

            return result;
        }
    }
}
