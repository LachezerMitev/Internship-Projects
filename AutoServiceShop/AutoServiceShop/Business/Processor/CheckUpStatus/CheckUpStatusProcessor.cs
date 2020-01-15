using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;

namespace AutoServiceShop.Business.Processor.CheckUpStatus
{
    class CheckUpStatusProcessor : ICheckUpStatusProcessor
    {
<<<<<<< Updated upstream
        ICheckUpStatusDao CheckUpStatusDao = new CheckUpStatusDao();

        ICheckUpStatusParamConverter CheckUpStatusParamConverter = new CheckUpStatusParamConverter();
        ICheckUpStatusResultConverter CheckUpStatusResultConverter = new CheckUpStatusResultConverter();

        public CheckUpStatusResult Create(CheckUpStatusParam param)
        {
            Data.Entity.CheckUpStatus entity = CheckUpStatusParamConverter.Convert(param, null);
            CheckUpStatusDao.Save(entity);

            return CheckUpStatusResultConverter.Convert(entity);
        }

        public List<CheckUpStatusResult> Create(List<CheckUpStatusParam> param)
        {
            List<Data.Entity.CheckUpStatus> entities = new List<Data.Entity.CheckUpStatus>();
            foreach (var item in param)
            {
                entities.Add(CheckUpStatusParamConverter.Convert(item, null));
            }
            CheckUpStatusDao.Save(entities);
            List<CheckUpStatusResult> result = new List<CheckUpStatusResult>();
            foreach (var item in entities)
            {
                result.Add(CheckUpStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            CheckUpStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.CheckUpStatus> entity = new List<Data.Entity.CheckUpStatus>();
            foreach (var id in idList)
            {
                entity.Add(CheckUpStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                CheckUpStatusDao.Delete(id);
            }
        }

        public CheckUpStatusResult Find(long id)
        {
            Data.Entity.CheckUpStatus entity = CheckUpStatusDao.Find(id);
            CheckUpStatusResult result = CheckUpStatusResultConverter.Convert(entity);
            return result;
        }

        public List<CheckUpStatusResult> Find()
        {
            List<Data.Entity.CheckUpStatus> entity = CheckUpStatusDao.Find();
            List<CheckUpStatusResult> results = new List<CheckUpStatusResult>();
            foreach (var item in entity)
            {
                results.Add(CheckUpStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, CheckUpStatusParam param)
        {
            Data.Entity.CheckUpStatus oldEntity = CheckUpStatusDao.Find(id);
            Data.Entity.CheckUpStatus newEntity = CheckUpStatusParamConverter.Convert(param, null);
            CheckUpStatusDao.Update(newEntity);
        }

        public void Update(List<CheckUpStatusParam> param)
        {
            List<Data.Entity.CheckUpStatus> entity = new List<Data.Entity.CheckUpStatus>();
            foreach (var item in param)
            {
                Data.Entity.CheckUpStatus oldEntity = CheckUpStatusDao.Find(item.Id);
                Data.Entity.CheckUpStatus newEntity = CheckUpStatusParamConverter.Convert(item, null);
                CheckUpStatusDao.Update(newEntity);
            }
        }
=======
>>>>>>> Stashed changes
    }
}
