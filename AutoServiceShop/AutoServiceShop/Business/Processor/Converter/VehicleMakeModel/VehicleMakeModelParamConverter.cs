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
        private IVehicleDao _vehicleDao;
        public IVehicleDao VehicleDao
        {

            set { _vehicleDao = value; }

            get
            {
                if (_vehicleDao == null)
                {
                    return _vehicleDao;
                }
                else
                {
                    return _vehicleDao;
                }
            }
        }

        private IMakeDao _makeDao;
        public IMakeDao MakeDao
        {

            set { _makeDao = value; }

            get
            {
                if (_makeDao == null)
                {
                    return _makeDao;
                }
                else
                {
                    return _makeDao;
                }
            }
        }

        private IModelDao _modelDao;
        public IModelDao ModelDao
        {

            set { _modelDao = value; }

            get
            {
                if (_modelDao == null)
                {
                    return _modelDao;
                }
                else
                {
                    return _modelDao;
                }
            }
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
