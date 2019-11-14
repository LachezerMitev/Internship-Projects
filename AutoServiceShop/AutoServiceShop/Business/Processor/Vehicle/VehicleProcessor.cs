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
        IVehicleDao VehicleDao = new VehicleDao();

        IVehicleParamConverter VehicleParamConverter = new VehicleParamConverter();
        IVehicleResultConverter VehicleResultConverter = new VehicleResultConverter();

        public VehicleResult Create(VehicleParam param)
        {
            Data.Entity.Vehicle entity = VehicleParamConverter.Convert(param, null);
            VehicleDao.Save(entity);

            return VehicleResultConverter.Convert(entity);
        }

        public List<VehicleResult> Create(List<VehicleParam> param)
        {
            List<Data.Entity.Vehicle> entities = new List<Data.Entity.Vehicle>();
            foreach (var item in param)
            {
                entities.Add(VehicleParamConverter.Convert(item, null));
            }
            VehicleDao.Save(entities);
            List<VehicleResult> result = new List<VehicleResult>();
            foreach (var item in entities)
            {
                result.Add(VehicleResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            VehicleDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Vehicle> entity = new List<Data.Entity.Vehicle>();
            foreach (var id in idList)
            {
                entity.Add(VehicleDao.Find(id));
            }
            foreach (var id in idList)
            {
                VehicleDao.Delete(id);
            }
        }

        public VehicleResult Find(long id)
        {
            Data.Entity.Vehicle entity = VehicleDao.Find(id);
            VehicleResult result = VehicleResultConverter.Convert(entity);
            return result;
        }

        public List<VehicleResult> Find()
        {
            List<Data.Entity.Vehicle> entity = VehicleDao.Find();
            List<VehicleResult> results = new List<VehicleResult>();
            foreach (var item in entity)
            {
                results.Add(VehicleResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, VehicleParam param)
        {
            Data.Entity.Vehicle oldEntity = VehicleDao.Find(id);
            Data.Entity.Vehicle newEntity = VehicleParamConverter.Convert(param, null);
            VehicleDao.Update(newEntity);
        }

        public void Update(List<VehicleParam> param)
        {
            List<Data.Entity.Vehicle> entity = new List<Data.Entity.Vehicle>();
            foreach (var item in param)
            {
                Data.Entity.Vehicle oldEntity = VehicleDao.Find(item.Id);
                Data.Entity.Vehicle newEntity = VehicleParamConverter.Convert(item, null);
                VehicleDao.Update(newEntity);
            }
        }
    }
}
