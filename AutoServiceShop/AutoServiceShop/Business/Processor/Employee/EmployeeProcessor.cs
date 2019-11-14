using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Employee;
using AutoServiceShop.Business.Processor.Converter.Employee;

namespace AutoServiceShop.Business.Processor.Employee
{
    class EmployeeProcessor : IEmployeeProcessor
    {
        IEmployeeDao EmployeeDao = new EmployeeDao();

        IEmployeeParamConverter EmployeeParamConverter = new EmployeeParamConverter();
        IEmployeeResultConverter EmployeeResultConverter = new EmployeeResultConverter();

        public EmployeeResult Create(EmployeeParam param)
        {
            Data.Entity.Employee entity = EmployeeParamConverter.Convert(param, null);
            EmployeeDao.Save(entity);

            return EmployeeResultConverter.Convert(entity);
        }

        public List<EmployeeResult> Create(List<EmployeeParam> param)
        {
            List<Data.Entity.Employee> entities = new List<Data.Entity.Employee>();
            foreach (var item in param)
            {
                entities.Add(EmployeeParamConverter.Convert(item, null));
            }
            EmployeeDao.Save(entities);
            List<EmployeeResult> result = new List<EmployeeResult>();
            foreach (var item in entities)
            {
                result.Add(EmployeeResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            EmployeeDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Employee> entity = new List<Data.Entity.Employee>();
            foreach (var id in idList)
            {
                entity.Add(EmployeeDao.Find(id));
            }
            foreach (var id in idList)
            {
                EmployeeDao.Delete(id);
            }
        }

        public EmployeeResult Find(long id)
        {
            Data.Entity.Employee entity = EmployeeDao.Find(id);
            EmployeeResult result = EmployeeResultConverter.Convert(entity);
            return result;
        }

        public List<EmployeeResult> Find()
        {
            List<Data.Entity.Employee> entity = EmployeeDao.Find();
            List<EmployeeResult> results = new List<EmployeeResult>();
            foreach (var item in entity)
            {
                results.Add(EmployeeResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, EmployeeParam param)
        {
            Data.Entity.Employee oldEntity = EmployeeDao.Find(id);
            Data.Entity.Employee newEntity = EmployeeParamConverter.Convert(param, null);
            EmployeeDao.Update(newEntity);
        }

        public void Update(List<EmployeeParam> param)
        {
            List<Data.Entity.Employee> entity = new List<Data.Entity.Employee>();
            foreach (var item in param)
            {
                Data.Entity.Employee oldEntity = EmployeeDao.Find(item.Id);
                Data.Entity.Employee newEntity = EmployeeParamConverter.Convert(item, null);
                EmployeeDao.Update(newEntity);
            }
        }
    }
}
