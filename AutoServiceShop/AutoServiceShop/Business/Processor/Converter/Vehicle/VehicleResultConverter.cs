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
<<<<<<< Updated upstream
            VehicleResult result = new VehicleResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,

                VehicleStatusId = param.VehicleStatus.Id,
                VehicleStatusName = param.VehicleStatus.Name,
                DateOfProduction = param.DateOfProduction,
                Mileage = param.Mileage,
                OwnerId = param.Owner.Id,
                OwnerName = param.Owner.Name
            };

            return result;
=======
            if (param.VehicleStatus == null)
                throw new Exception("Some or all items in the entity taht are crucial were not found");

            result.VehicleStatusId = param.VehicleStatus.Id;
            result.VehicleStatusName = param.VehicleStatus.Name;
>>>>>>> Stashed changes
        }
    }
}
