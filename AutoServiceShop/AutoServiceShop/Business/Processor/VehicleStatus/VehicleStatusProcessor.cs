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
<<<<<<< Updated upstream
        IVehicleStatusDao VehicleStatusDao = new VehicleStatusDao();

        IVehicleStatusParamConverter VehicleStatusParamConverter = new VehicleStatusParamConverter();
        IVehicleStatusResultConverter VehicleStatusResultConverter = new VehicleStatusResultConverter();

        public VehicleStatusResult Create(VehicleStatusParam param)
        {
            Data.Entity.VehicleStatus entity = VehicleStatusParamConverter.Convert(param, null);
            VehicleStatusDao.Save(entity);

            return VehicleStatusResultConverter.Convert(entity);
        }

        public List<VehicleStatusResult> Create(List<VehicleStatusParam> param)
        {
            List<Data.Entity.VehicleStatus> entities = new List<Data.Entity.VehicleStatus>();
            foreach (var item in param)
            {
                entities.Add(VehicleStatusParamConverter.Convert(item, null));
            }
            VehicleStatusDao.Save(entities);
            List<VehicleStatusResult> result = new List<VehicleStatusResult>();
            foreach (var item in entities)
            {
                result.Add(VehicleStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            VehicleStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.VehicleStatus> entity = new List<Data.Entity.VehicleStatus>();
            foreach (var id in idList)
            {
                entity.Add(VehicleStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                VehicleStatusDao.Delete(id);
            }
        }

        public VehicleStatusResult Find(long id)
        {
            Data.Entity.VehicleStatus entity = VehicleStatusDao.Find(id);
            VehicleStatusResult result = VehicleStatusResultConverter.Convert(entity);
            return result;
        }

        public List<VehicleStatusResult> Find()
        {
            List<Data.Entity.VehicleStatus> entity = VehicleStatusDao.Find();
            List<VehicleStatusResult> results = new List<VehicleStatusResult>();
            foreach (var item in entity)
            {
                results.Add(VehicleStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, VehicleStatusParam param)
        {
            Data.Entity.VehicleStatus oldEntity = VehicleStatusDao.Find(id);
            Data.Entity.VehicleStatus newEntity = VehicleStatusParamConverter.Convert(param, null);
            VehicleStatusDao.Update(newEntity);
        }

        public void Update(List<VehicleStatusParam> param)
        {
            List<Data.Entity.VehicleStatus> entity = new List<Data.Entity.VehicleStatus>();
            foreach (var item in param)
            {
                Data.Entity.VehicleStatus oldEntity = VehicleStatusDao.Find(item.Id);
                Data.Entity.VehicleStatus newEntity = VehicleStatusParamConverter.Convert(item, null);
                VehicleStatusDao.Update(newEntity);
            }
        }
=======
>>>>>>> Stashed changes
    }
}
