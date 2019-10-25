using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Vehicle
{
    class VehicleResultConverter : IVehicleResultConverter
    {
        public VehicleResult Convert(Data.Entity.Vehicle param)
        {
            VehicleResult result = new VehicleResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,

                VehicleStatus = param.VehicleStatus,
                DateOfProduction = param.DateOfProduction,
                Mileage = param.Mileage,
                Owner = param.Owner
            };

            return result;
        }
    }
}
