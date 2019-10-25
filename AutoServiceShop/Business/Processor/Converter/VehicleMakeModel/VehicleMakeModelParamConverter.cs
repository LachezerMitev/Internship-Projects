using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.VehicleMakeModel;

namespace AutoServiceShop.Business.Processor.Converter.VehicleMakeModel
{
    class VehicleMakeModelParamConverter : IVehicleMakeModelParamConverter
    {
        IVehicleMakeModelDao VehicleMakeModelDao { get; set; }

        public Data.Entity.VehicleMakeModel Convert(VehicleMakeModelParam param)
        {
            Data.Entity.VehicleMakeModel result = new Data.Entity.VehicleMakeModel()
            {
                Id = param.Id,

                Vehicle = param.Vehicle,
                Make = param.Make,
                ModelList = param.ModelList
            };

            return result;
        }

        public Data.Entity.VehicleMakeModel Convert(VehicleMakeModelParam param, Data.Entity.VehicleMakeModel oldentity)
        {
            Data.Entity.VehicleMakeModel entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.VehicleMakeModel();
            }

            entity.Id = param.Id;
            entity.Vehicle = param.Vehicle;
            entity.ModelList = param.ModelList;
            entity.Make = param.Make;

            return entity;
        }
    }
}
