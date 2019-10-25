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

        public Data.Entity.VehicleStatus Convert(VehicleStatusParam param)
        {
            Data.Entity.VehicleStatus result = new Data.Entity.VehicleStatus()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }

        public Data.Entity.VehicleStatus Convert(VehicleStatusParam param, Data.Entity.VehicleStatus oldentity)
        {
            Data.Entity.VehicleStatus entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.VehicleStatus();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;

            return entity;
        }
    }
}
