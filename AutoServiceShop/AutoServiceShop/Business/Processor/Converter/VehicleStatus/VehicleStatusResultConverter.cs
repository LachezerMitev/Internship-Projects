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
        public override void ConvertSpecific(Data.Entity.VehicleStatus param, VehicleStatusResult result)
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
