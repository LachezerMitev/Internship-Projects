using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.VehicleStatus;
using AutoServiceShop.Business.Processor.Converter.VehicleStatus;

namespace AutoServiceShop.Business.Processor.VehicleStatus
{
    class VehicleStatusProcessor : IVehicleStatusProcessor
    {
        private IVehicleStatusParamConverter _vehicleStatusParamConverter;
        public IVehicleStatusParamConverter VehicleStatusParamConverter
        {
            set => _vehicleStatusParamConverter = value;
            get
            {
                if (_vehicleStatusParamConverter == null)
                {
                    _vehicleStatusParamConverter = new VehicleStatusParamConverter();
                    return _vehicleStatusParamConverter;
                }
                else
                {
                    return _vehicleStatusParamConverter;
                }
            }
        }

        private IVehicleStatusResultConverter _vehicleStatusResultConverter;
        public IVehicleStatusResultConverter VehicleStatusResultConverter
        {
            set => _vehicleStatusResultConverter = value;
            get
            {
                if (_vehicleStatusResultConverter == null)
                {
                    _vehicleStatusResultConverter = new VehicleStatusResultConverter();
                    return _vehicleStatusResultConverter;
                }
                else
                {
                    return _vehicleStatusResultConverter;
                }
            }
        }

        private IVehicleStatusDao _vehicleStatusDao;
        public IVehicleStatusDao VehicleStatusDataObject
        {
            set => _vehicleStatusDao = value;
            get
            {
                if (_vehicleStatusDao == null)
                {
                    _vehicleStatusDao = new VehicleStatusDao();
                    return _vehicleStatusDao;
                }
                else
                {
                    return _vehicleStatusDao;
                }
            }
        }


        public VehicleStatusResult Create(VehicleStatusParam param)
        {

            Data.Entity.VehicleStatus entity = _vehicleStatusParamConverter.Convert(param, null);

            _vehicleStatusDao.Save(entity);

            return _vehicleStatusResultConverter.Convert(entity);
        }

        public List<VehicleStatusResult> Create(List<VehicleStatusParam> param)
        {
            List<Data.Entity.VehicleStatus> entities = new List<Data.Entity.VehicleStatus>();
            foreach (var item in param)
            {
                entities.Add(_vehicleStatusParamConverter.Convert(item, null));
            }
            _vehicleStatusDao.Save(entities);
            List<VehicleStatusResult> result = new List<VehicleStatusResult>();
            foreach (var item in entities)
            {
                result.Add(_vehicleStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _vehicleStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.VehicleStatus> entity = new List<Data.Entity.VehicleStatus>();
            foreach (var id in idList)
            {
                entity.Add(_vehicleStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                _vehicleStatusDao.Delete(id);
            }
        }

        public VehicleStatusResult Find(long id)
        {
            try
            {
                Data.Entity.VehicleStatus entity = _vehicleStatusDao.Find(id);
                VehicleStatusResult result = _vehicleStatusResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<VehicleStatusResult> Find()
        {
            List<Data.Entity.VehicleStatus> VehicleStatuss = _vehicleStatusDao.Find();
            List<VehicleStatusResult> results = new List<VehicleStatusResult>();
            foreach (var item in VehicleStatuss)
            {
                results.Add(_vehicleStatusResultConverter.Convert(item));
            }
            return results;
        }

        public List<VehicleStatusResult> FindByField(string field, string value)
        {
            List<Data.Entity.VehicleStatus> VehicleStatuss = _vehicleStatusDao.FindByField(field, value);
            List<VehicleStatusResult> results = new List<VehicleStatusResult>();
            foreach (var item in VehicleStatuss)
            {
                results.Add(_vehicleStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, VehicleStatusParam param)
        {
            Data.Entity.VehicleStatus oldEntity = _vehicleStatusDao.Find(id);
            Data.Entity.VehicleStatus newEntity = _vehicleStatusParamConverter.Convert(param, oldEntity);
            _vehicleStatusDao.Update(newEntity);
        }

        public void Update(List<VehicleStatusParam> param)
        {
            List<Data.Entity.VehicleStatus> entity = new List<Data.Entity.VehicleStatus>();
            foreach (var item in param)
            {
                Data.Entity.VehicleStatus oldEntity = _vehicleStatusDao.Find(item.Id);
                Data.Entity.VehicleStatus newEntity = _vehicleStatusParamConverter.Convert(item, oldEntity);
                _vehicleStatusDao.Update(newEntity);
            }
        }
    }
}
