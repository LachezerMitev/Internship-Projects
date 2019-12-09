using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.VehicleMakeModel;
using AutoServiceShop.Business.Processor.Converter.VehicleMakeModel;

namespace AutoServiceShop.Business.Processor.VehicleMakeModel
{
    class VehicleMakeModelProcessor : IVehicleMakeModelProcessor
    {
        private IVehicleMakeModelParamConverter _vehicleMakeModelParamConverter;
        public IVehicleMakeModelParamConverter VehicleMakeModelParamConverter
        {
            set => _vehicleMakeModelParamConverter = value;
            get
            {
                if (_vehicleMakeModelParamConverter == null)
                {
                    _vehicleMakeModelParamConverter = new VehicleMakeModelParamConverter();
                    return _vehicleMakeModelParamConverter;
                }
                else
                {
                    return _vehicleMakeModelParamConverter;
                }
            }
        }

        private IVehicleMakeModelResultConverter _vehicleMakeModelResultConverter;
        public IVehicleMakeModelResultConverter VehicleMakeModelResultConverter
        {
            set => _vehicleMakeModelResultConverter = value;
            get
            {
                if (_vehicleMakeModelResultConverter == null)
                {
                    _vehicleMakeModelResultConverter = new VehicleMakeModelResultConverter();
                    return _vehicleMakeModelResultConverter;
                }
                else
                {
                    return _vehicleMakeModelResultConverter;
                }
            }
        }

        private IVehicleMakeModelDao _vehicleMakeModelDao;
        public IVehicleMakeModelDao VehicleMakeModelDataObject
        {
            set => _vehicleMakeModelDao = value;
            get
            {
                if (_vehicleMakeModelDao == null)
                {
                    _vehicleMakeModelDao = new VehicleMakeModelDao();
                    return _vehicleMakeModelDao;
                }
                else
                {
                    return _vehicleMakeModelDao;
                }
            }
        }


        public VehicleMakeModelResult Create(VehicleMakeModelParam param)
        {

            Data.Entity.VehicleMakeModel entity = _vehicleMakeModelParamConverter.Convert(param, null);

            _vehicleMakeModelDao.Save(entity);

            return _vehicleMakeModelResultConverter.Convert(entity);
        }

        public List<VehicleMakeModelResult> Create(List<VehicleMakeModelParam> param)
        {
            List<Data.Entity.VehicleMakeModel> entities = new List<Data.Entity.VehicleMakeModel>();
            foreach (var item in param)
            {
                entities.Add(_vehicleMakeModelParamConverter.Convert(item, null));
            }
            _vehicleMakeModelDao.Save(entities);
            List<VehicleMakeModelResult> result = new List<VehicleMakeModelResult>();
            foreach (var item in entities)
            {
                result.Add(_vehicleMakeModelResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _vehicleMakeModelDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.VehicleMakeModel> entity = new List<Data.Entity.VehicleMakeModel>();
            foreach (var id in idList)
            {
                entity.Add(_vehicleMakeModelDao.Find(id));
            }
            foreach (var id in idList)
            {
                _vehicleMakeModelDao.Delete(id);
            }
        }

        public VehicleMakeModelResult Find(long id)
        {
            try
            {
                Data.Entity.VehicleMakeModel entity = _vehicleMakeModelDao.Find(id);
                VehicleMakeModelResult result = _vehicleMakeModelResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<VehicleMakeModelResult> Find()
        {
            List<Data.Entity.VehicleMakeModel> VehicleMakeModels = _vehicleMakeModelDao.Find();
            List<VehicleMakeModelResult> results = new List<VehicleMakeModelResult>();
            foreach (var item in VehicleMakeModels)
            {
                results.Add(_vehicleMakeModelResultConverter.Convert(item));
            }
            return results;
        }

        public List<VehicleMakeModelResult> FindByField(string field, string value)
        {
            List<Data.Entity.VehicleMakeModel> VehicleMakeModels = _vehicleMakeModelDao.FindByField(field, value);
            List<VehicleMakeModelResult> results = new List<VehicleMakeModelResult>();
            foreach (var item in VehicleMakeModels)
            {
                results.Add(_vehicleMakeModelResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, VehicleMakeModelParam param)
        {
            Data.Entity.VehicleMakeModel oldEntity = _vehicleMakeModelDao.Find(id);
            Data.Entity.VehicleMakeModel newEntity = _vehicleMakeModelParamConverter.Convert(param, oldEntity);
            _vehicleMakeModelDao.Update(newEntity);
        }

        public void Update(List<VehicleMakeModelParam> param)
        {
            List<Data.Entity.VehicleMakeModel> entity = new List<Data.Entity.VehicleMakeModel>();
            foreach (var item in param)
            {
                Data.Entity.VehicleMakeModel oldEntity = _vehicleMakeModelDao.Find(item.Id);
                Data.Entity.VehicleMakeModel newEntity = _vehicleMakeModelParamConverter.Convert(item, oldEntity);
                _vehicleMakeModelDao.Update(newEntity);
            }
        }
    }
}
