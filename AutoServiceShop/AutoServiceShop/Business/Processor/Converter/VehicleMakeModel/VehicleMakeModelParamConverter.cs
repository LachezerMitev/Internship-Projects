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
        private IVehicleDao _vehicleDao;
        public IVehicleDao VehicleDao
        {

            set { _vehicleDao = value; }

            get
            {
                if (_vehicleDao == null)
                {
                    _vehicleDao = new VehicleDao();
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
                    _makeDao = new MakeDao();
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
                    _modelDao = new ModelDao();
                    return _modelDao;
                }
                else
                {
                    return _modelDao;
                }
            }
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
                entity = new Data.Entity.VehicleMakeModel
                {
                    Id = param.Id
                };
            }
<<<<<<< Updated upstream
            
            entity.Vehicle = VehicleDao.Find(param.VehicleId);
            entity.Model = ModelDao.Find(param.Modelid);
            entity.Make = MakeDao.Find(param.MakeId);
=======

            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.VehicleMakeModel ConvertSpecific(VehicleMakeModelParam param, Data.Entity.VehicleMakeModel entity)
        {
            entity.Vehicle = _vehicleDao.Find(param.VehicleId);
            entity.Model = _modelDao.Find(param.Modelid);
            entity.Make = _makeDao.Find(param.MakeId);
>>>>>>> Stashed changes

            return entity;
        }
    }
}
