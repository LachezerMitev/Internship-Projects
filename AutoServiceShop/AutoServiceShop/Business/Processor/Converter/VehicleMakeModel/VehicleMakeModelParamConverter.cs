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

namespace AutoServiceShop.Business.Processor.Converter.VehicleMakeModel
{
    class VehicleMakeModelParamConverter : IVehicleMakeModelParamConverter
    {
<<<<<<< Updated upstream
        IVehicleMakeModelDao VehicleMakeModelDao = new VehicleMakeModelDao();
        IVehicleDao VehicleDao = new VehicleDao();
        IMakeDao MakeDao = new MakeDao();
        IModelDao ModelDao = new ModelDao();

        public Data.Entity.VehicleMakeModel Convert(VehicleMakeModelParam param, Data.Entity.VehicleMakeModel oldentity)
        {
            Data.Entity.VehicleMakeModel entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.VehicleMakeModel
                {
                    Id = param.Id
                };
            }
            
            entity.Vehicle = VehicleDao.Find(param.VehicleId);
            entity.Model = ModelDao.Find(param.Modelid);
            entity.Make = MakeDao.Find(param.MakeId);
=======
        private readonly IVehicleDao _vehicleDao;

        private readonly IMakeDao _makeDao;

        private readonly IModelDao _modelDao;

        public VehicleMakeModelParamConverter(IVehicleDao vehicleDao, IMakeDao makeDao, IModelDao modelDao)
        {
            _vehicleDao = vehicleDao;
            _makeDao = makeDao;
            _modelDao = modelDao;
        }

        public override void ConvertSpecific(VehicleMakeModelParam param, Data.Entity.VehicleMakeModel entity)
        {
            entity.Vehicle = _vehicleDao.Find(param.VehicleId);
            entity.Model = _modelDao.Find(param.Modelid);
            entity.Make = _makeDao.Find(param.MakeId);
        }

        public override Data.Entity.VehicleMakeModel GetResult(VehicleMakeModelParam param)
        {
            Data.Entity.VehicleMakeModel entity = new Data.Entity.VehicleMakeModel
            {
                Id = param.Id
            };
>>>>>>> Stashed changes

            return entity;
        }
    }
}
