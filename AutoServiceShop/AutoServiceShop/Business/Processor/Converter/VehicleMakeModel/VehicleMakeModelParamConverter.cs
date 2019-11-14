using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.VehicleMakeModel;
using AutoServiceShop.Dataaccess.Dao.Vehicle;
using AutoServiceShop.Dataaccess.Dao.Model;
using AutoServiceShop.Dataaccess.Dao.Make;
using AutoServiceShop.Business.Processor.Converter.Common;

namespace AutoServiceShop.Business.Processor.Converter.VehicleMakeModel
{
    class VehicleMakeModelParamConverter : BaseParamConverter<VehicleMakeModelParam, Data.Entity.VehicleMakeModel>, IVehicleMakeModelParamConverter
    {
        IVehicleMakeModelDao VehicleMakeModelDao = new VehicleMakeModelDao();
        IVehicleDao VehicleDao = new VehicleDao();
        IMakeDao MakeDao = new MakeDao();
        IModelDao ModelDao = new ModelDao();

        public Data.Entity.VehicleMakeModel Convert(VehicleMakeModelParam param, Data.Entity.VehicleMakeModel oldentity)
        {
            Data.Entity.VehicleMakeModel entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.VehicleMakeModel
                {
                    Id = param.Id
                };
            }

            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.VehicleMakeModel ConvertSpecific(VehicleMakeModelParam param, Data.Entity.VehicleMakeModel entity)
        {
            entity.Vehicle = VehicleDao.Find(param.VehicleId);
            entity.Model = ModelDao.Find(param.Modelid);
            entity.Make = MakeDao.Find(param.MakeId);

            return entity;
        }
    }
}
