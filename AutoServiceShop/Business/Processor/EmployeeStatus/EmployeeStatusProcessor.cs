using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.EmployeeStatus;
using AutoServiceShop.Business.Processor.Converter.EmployeeStatus;

namespace AutoServiceShop.Business.Processor.EmployeeStatus
{
    class EmployeeStatusProcessor : IEmployeeStatusProcessor
    {
        IEmployeeStatusDao EmployeeStatusDao = new EmployeeStatusDao();

        IEmployeeStatusParamConverter EmployeeStatusParamConverter = new EmployeeStatusParamConverter();
        IEmployeeStatusResultConverter EmployeeStatusResultConverter = new EmployeeStatusResultConverter();

        public EmployeeStatusResult Create(EmployeeStatusParam param)
        {
            Data.Entity.EmployeeStatus entity = EmployeeStatusParamConverter.Convert(param);
            EmployeeStatusDao.Save(entity);

            return EmployeeStatusResultConverter.Convert(entity);
        }

        public List<EmployeeStatusResult> Create(List<EmployeeStatusParam> param)
        {
            List<Data.Entity.EmployeeStatus> entities = new List<Data.Entity.EmployeeStatus>();
            foreach (var item in param)
            {
                entities.Add(EmployeeStatusParamConverter.Convert(item));
            }
            EmployeeStatusDao.Save(entities);
            List<EmployeeStatusResult> result = new List<EmployeeStatusResult>();
            foreach (var item in entities)
            {
                result.Add(EmployeeStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            EmployeeStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.EmployeeStatus> entity = new List<Data.Entity.EmployeeStatus>();
            foreach (var id in idList)
            {
                entity.Add(EmployeeStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                EmployeeStatusDao.Delete(id);
            }
        }

        public EmployeeStatusResult Find(long id)
        {
            Data.Entity.EmployeeStatus entity = EmployeeStatusDao.Find(id);
            EmployeeStatusResult result = EmployeeStatusResultConverter.Convert(entity);
            return result;
        }

        public List<EmployeeStatusResult> Find()
        {
            List<Data.Entity.EmployeeStatus> accounts = EmployeeStatusDao.Find();
            List<EmployeeStatusResult> results = new List<EmployeeStatusResult>();
            foreach (var item in accounts)
            {
                results.Add(EmployeeStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, EmployeeStatusParam param)
        {
            Data.Entity.EmployeeStatus oldEntity = EmployeeStatusDao.Find(id);
            Data.Entity.EmployeeStatus newEntity = EmployeeStatusParamConverter.Convert(param);
            EmployeeStatusDao.Update(newEntity);
        }

        public void Update(List<EmployeeStatusParam> param)
        {
            List<Data.Entity.EmployeeStatus> entity = new List<Data.Entity.EmployeeStatus>();
            foreach (var item in param)
            {
                Data.Entity.EmployeeStatus oldEntity = EmployeeStatusDao.Find(item.Id);
                Data.Entity.EmployeeStatus newEntity = EmployeeStatusParamConverter.Convert(item);
                EmployeeStatusDao.Update(newEntity);
            }
        }
    }
}
