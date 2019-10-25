using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Customer;
using AutoServiceShop.Business.Processor.Converter.Customer;

namespace AutoServiceShop.Business.Processor.Customer
{
    class CustomerProcessor : ICustomerProcessor
    {
        ICustomerDao CustomerDao = new CustomerDao();

        ICustomerParamConverter CustomerParamConverter = new CustomerParamConverter();
        ICustomerResultConverter CustomerResultConverter = new CustomerResultConverter();

        public CustomerResult Create(CustomerParam param)
        {
            Data.Entity.Customer entity = CustomerParamConverter.Convert(param);
            CustomerDao.Save(entity);

            return CustomerResultConverter.Convert(entity);
        }

        public List<CustomerResult> Create(List<CustomerParam> param)
        {
            List<Data.Entity.Customer> entities = new List<Data.Entity.Customer>();
            foreach (var item in param)
            {
                entities.Add(CustomerParamConverter.Convert(item));
            }
            CustomerDao.Save(entities);
            List<CustomerResult> result = new List<CustomerResult>();
            foreach (var item in entities)
            {
                result.Add(CustomerResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            CustomerDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Customer> entity = new List<Data.Entity.Customer>();
            foreach (var id in idList)
            {
                entity.Add(CustomerDao.Find(id));
            }
            foreach (var id in idList)
            {
                CustomerDao.Delete(id);
            }
        }

        public CustomerResult Find(long id)
        {
            Data.Entity.Customer entity = CustomerDao.Find(id);
            CustomerResult result = CustomerResultConverter.Convert(entity);
            return result;
        }

        public List<CustomerResult> Find()
        {
            List<Data.Entity.Customer> accounts = CustomerDao.Find();
            List<CustomerResult> results = new List<CustomerResult>();
            foreach (var item in accounts)
            {
                results.Add(CustomerResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, CustomerParam param)
        {
            Data.Entity.Customer oldEntity = CustomerDao.Find(id);
            Data.Entity.Customer newEntity = CustomerParamConverter.Convert(param);
            CustomerDao.Update(newEntity);
        }

        public void Update(List<CustomerParam> param)
        {
            List<Data.Entity.Customer> entity = new List<Data.Entity.Customer>();
            foreach (var item in param)
            {
                Data.Entity.Customer oldEntity = CustomerDao.Find(item.Id);
                Data.Entity.Customer newEntity = CustomerParamConverter.Convert(item);
                CustomerDao.Update(newEntity);
            }
        }
    }
}
