using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.VehicleStatus;

namespace AutoServiceShop.Business.Processor.Converter.VehicleStatus
{
    class VehicleStatusParamConverter : IVehicleStatusParamConverter
    {
        IVehicleStatusDao VehicleStatusDao { get; set; }

        public Data.Entity.VehicleStatus Convert(VehicleStatusParam param, Data.Entity.VehicleStatus oldentity)
        {
<<<<<<< Updated upstream
            Data.Entity.VehicleStatus entity = null;
=======
            Data.Entity.VehicleStatus entity = new Data.Entity.VehicleStatus
            {
                Id = param.Id,
                Code = param.Code,
                Active = param.Active
            };
>>>>>>> Stashed changes

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.VehicleStatus
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }
            
            return entity;
        }
    }
}
