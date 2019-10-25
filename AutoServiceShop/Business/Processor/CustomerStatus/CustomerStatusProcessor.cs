using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.CustomerStatus;
using AutoServiceShop.Business.Processor.Converter.CustomerStatus;

namespace AutoServiceShop.Business.Processor.CustomerStatus
{
    class CustomerStatusProcessor : ICustomerStatusProcessor
    {
        ICustomerStatusDao CustomerStatusDao = new CustomerStatusDao();

        ICustomerStatusParamConverter CustomerStatusParamConverter = new CustomerStatusParamConverter();
        ICustomerStatusResultConverter CustomerStatusResultConverter = new CustomerStatusResultConverter();

        public CustomerStatusResult Create(CustomerStatusParam param)
        {
            Data.Entity.CustomerStatus entity = CustomerStatusParamConverter.Convert(param);
            CustomerStatusDao.Save(entity);

            return CustomerStatusResultConverter.Convert(entity);
        }

        public List<CustomerStatusResult> Create(List<CustomerStatusParam> param)
        {
            List<Data.Entity.CustomerStatus> entities = new List<Data.Entity.CustomerStatus>();
            foreach (var item in param)
            {
                entities.Add(CustomerStatusParamConverter.Convert(item));
            }
            CustomerStatusDao.Save(entities);
            List<CustomerStatusResult> result = new List<CustomerStatusResult>();
            foreach (var item in entities)
            {
                result.Add(CustomerStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            CustomerStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.CustomerStatus> entity = new List<Data.Entity.CustomerStatus>();
            foreach (var id in idList)
            {
                entity.Add(CustomerStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                CustomerStatusDao.Delete(id);
            }
        }

        public CustomerStatusResult Find(long id)
        {
            Data.Entity.CustomerStatus entity = CustomerStatusDao.Find(id);
            CustomerStatusResult result = CustomerStatusResultConverter.Convert(entity);
            return result;
        }

        public List<CustomerStatusResult> Find()
        {
            List<Data.Entity.CustomerStatus> accounts = CustomerStatusDao.Find();
            List<CustomerStatusResult> results = new List<CustomerStatusResult>();
            foreach (var item in accounts)
            {
                results.Add(CustomerStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, CustomerStatusParam param)
        {
            Data.Entity.CustomerStatus oldEntity = CustomerStatusDao.Find(id);
            Data.Entity.CustomerStatus newEntity = CustomerStatusParamConverter.Convert(param);
            CustomerStatusDao.Update(newEntity);
        }

        public void Update(List<CustomerStatusParam> param)
        {
            List<Data.Entity.CustomerStatus> entity = new List<Data.Entity.CustomerStatus>();
            foreach (var item in param)
            {
                Data.Entity.CustomerStatus oldEntity = CustomerStatusDao.Find(item.Id);
                Data.Entity.CustomerStatus newEntity = CustomerStatusParamConverter.Convert(item);
                CustomerStatusDao.Update(newEntity);
            }
        }
    }
}
