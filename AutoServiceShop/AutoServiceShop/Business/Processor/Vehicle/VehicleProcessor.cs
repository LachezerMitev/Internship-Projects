using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Vehicle;
using AutoServiceShop.Business.Processor.Converter.Vehicle;

namespace AutoServiceShop.Business.Processor.Vehicle
{
    class VehicleProcessor : IVehicleProcessor
    {
        private IVehicleParamConverter _vehicleParamConverter;
        public IVehicleParamConverter VehicleParamConverter
        {
            set => _vehicleParamConverter = value;
            get
            {
                if (_vehicleParamConverter == null)
                {
                    _vehicleParamConverter = new VehicleParamConverter();
                    return _vehicleParamConverter;
                }
                else
                {
                    return _vehicleParamConverter;
                }
            }
        }

        private IVehicleResultConverter _vehicleResultConverter;
        public IVehicleResultConverter VehicleResultConverter
        {
            set => _vehicleResultConverter = value;
            get
            {
                if (_vehicleResultConverter == null)
                {
                    _vehicleResultConverter = new VehicleResultConverter();
                    return _vehicleResultConverter;
                }
                else
                {
                    return _vehicleResultConverter;
                }
            }
        }

        private IVehicleDao _vehicleDao;
        public IVehicleDao VehicleDataObject
        {
            set => _vehicleDao = value;
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


        public VehicleResult Create(VehicleParam param)
        {

            Data.Entity.Vehicle entity = _vehicleParamConverter.Convert(param, null);

            _vehicleDao.Save(entity);

            return _vehicleResultConverter.Convert(entity);
        }

        public List<VehicleResult> Create(List<VehicleParam> param)
        {
            List<Data.Entity.Vehicle> entities = new List<Data.Entity.Vehicle>();
            foreach (var item in param)
            {
                entities.Add(_vehicleParamConverter.Convert(item, null));
            }
            _vehicleDao.Save(entities);
            List<VehicleResult> result = new List<VehicleResult>();
            foreach (var item in entities)
            {
                result.Add(_vehicleResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _vehicleDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Vehicle> entity = new List<Data.Entity.Vehicle>();
            foreach (var id in idList)
            {
                entity.Add(_vehicleDao.Find(id));
            }
            foreach (var id in idList)
            {
                _vehicleDao.Delete(id);
            }
        }

        public VehicleResult Find(long id)
        {
            try
            {
                Data.Entity.Vehicle entity = _vehicleDao.Find(id);
                VehicleResult result = _vehicleResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<VehicleResult> Find()
        {
            List<Data.Entity.Vehicle> Vehicles = _vehicleDao.Find();
            List<VehicleResult> results = new List<VehicleResult>();
            foreach (var item in Vehicles)
            {
                results.Add(_vehicleResultConverter.Convert(item));
            }
            return results;
        }

        public List<VehicleResult> FindByField(string field, string value)
        {
            List<Data.Entity.Vehicle> Vehicles = _vehicleDao.FindByField(field, value);
            List<VehicleResult> results = new List<VehicleResult>();
            foreach (var item in Vehicles)
            {
                results.Add(_vehicleResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, VehicleParam param)
        {
            Data.Entity.Vehicle oldEntity = _vehicleDao.Find(id);
            Data.Entity.Vehicle newEntity = _vehicleParamConverter.Convert(param, oldEntity);
            _vehicleDao.Update(newEntity);
        }

        public void Update(List<VehicleParam> param)
        {
            List<Data.Entity.Vehicle> entity = new List<Data.Entity.Vehicle>();
            foreach (var item in param)
            {
                Data.Entity.Vehicle oldEntity = _vehicleDao.Find(item.Id);
                Data.Entity.Vehicle newEntity = _vehicleParamConverter.Convert(item, oldEntity);
                _vehicleDao.Update(newEntity);
            }
        }
    }
}
