using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.VehicleStatus
{
    class VehicleStatusResultConverter : IVehicleStatusResultConverter
    {
        public VehicleStatusResult Convert(Data.Entity.VehicleStatus param)
        {
<<<<<<< Updated upstream
            VehicleStatusResult result = new VehicleStatusResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
=======
>>>>>>> Stashed changes
        }
    }
}
