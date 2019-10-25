using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Vehicle;

namespace AutoServiceShop.Business.Processor.Converter.Vehicle
{
    class VehicleParamConverter : IVehicleParamConverter
    {
        IVehicleDao VehicleDao { get; set; }

        public Data.Entity.Vehicle Convert(VehicleParam param)
        {
            Data.Entity.Vehicle result = new Data.Entity.Vehicle()
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

        public Data.Entity.Vehicle Convert(VehicleParam param, Data.Entity.Vehicle oldentity)
        {
            Data.Entity.Vehicle entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.Vehicle();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;

            entity.Owner = param.Owner;
            entity.Mileage = param.Mileage;
            entity.DateOfProduction = param.DateOfProduction;
            entity.VehicleStatus = param.VehicleStatus;

            return entity;
        }
    }
}
