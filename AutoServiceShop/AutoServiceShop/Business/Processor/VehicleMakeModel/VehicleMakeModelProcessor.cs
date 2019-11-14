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
        IVehicleMakeModelDao VehicleMakeModelDao = new VehicleMakeModelDao();

        IVehicleMakeModelParamConverter VehicleMakeModelParamConverter = new VehicleMakeModelParamConverter();
        IVehicleMakeModelResultConverter VehicleMakeModelResultConverter = new VehicleMakeModelResultConverter();

        public VehicleMakeModelResult Create(VehicleMakeModelParam param)
        {
            Data.Entity.VehicleMakeModel entity = VehicleMakeModelParamConverter.Convert(param, null);
            VehicleMakeModelDao.Save(entity);

            return VehicleMakeModelResultConverter.Convert(entity);
        }

        public List<VehicleMakeModelResult> Create(List<VehicleMakeModelParam> param)
        {
            List<Data.Entity.VehicleMakeModel> entities = new List<Data.Entity.VehicleMakeModel>();
            foreach (var item in param)
            {
                entities.Add(VehicleMakeModelParamConverter.Convert(item, null));
            }
            VehicleMakeModelDao.Save(entities);
            List<VehicleMakeModelResult> result = new List<VehicleMakeModelResult>();
            foreach (var item in entities)
            {
                result.Add(VehicleMakeModelResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            VehicleMakeModelDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.VehicleMakeModel> entity = new List<Data.Entity.VehicleMakeModel>();
            foreach (var id in idList)
            {
                entity.Add(VehicleMakeModelDao.Find(id));
            }
            foreach (var id in idList)
            {
                VehicleMakeModelDao.Delete(id);
            }
        }

        public VehicleMakeModelResult Find(long id)
        {
            Data.Entity.VehicleMakeModel entity = VehicleMakeModelDao.Find(id);
            VehicleMakeModelResult result = VehicleMakeModelResultConverter.Convert(entity);
            return result;
        }

        public List<VehicleMakeModelResult> Find()
        {
            List<Data.Entity.VehicleMakeModel> entity = VehicleMakeModelDao.Find();
            List<VehicleMakeModelResult> results = new List<VehicleMakeModelResult>();
            foreach (var item in entity)
            {
                results.Add(VehicleMakeModelResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, VehicleMakeModelParam param)
        {
            Data.Entity.VehicleMakeModel oldEntity = VehicleMakeModelDao.Find(id);
            Data.Entity.VehicleMakeModel newEntity = VehicleMakeModelParamConverter.Convert(param, null);
            VehicleMakeModelDao.Update(newEntity);
        }

        public void Update(List<VehicleMakeModelParam> param)
        {
            List<Data.Entity.VehicleMakeModel> entity = new List<Data.Entity.VehicleMakeModel>();
            foreach (var item in param)
            {
                Data.Entity.VehicleMakeModel oldEntity = VehicleMakeModelDao.Find(item.Id);
                Data.Entity.VehicleMakeModel newEntity = VehicleMakeModelParamConverter.Convert(item, null);
                VehicleMakeModelDao.Update(newEntity);
            }
        }
    }
}
