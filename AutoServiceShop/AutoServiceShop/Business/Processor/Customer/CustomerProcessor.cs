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
        private ICustomerParamConverter _customerParamConverter;
        public ICustomerParamConverter CustomerParamConverter
        {
            set => _customerParamConverter = value;
            get
            {
                if (_customerParamConverter == null)
                {
                    _customerParamConverter = new CustomerParamConverter();
                    return _customerParamConverter;
                }
                else
                {
                    return _customerParamConverter;
                }
            }
        }

        private ICustomerResultConverter _customerResultConverter;
        public ICustomerResultConverter CustomerResultConverter
        {
            set => _customerResultConverter = value;
            get
            {
                if (_customerResultConverter == null)
                {
                    _customerResultConverter = new CustomerResultConverter();
                    return _customerResultConverter;
                }
                else
                {
                    return _customerResultConverter;
                }
            }
        }

        private ICustomerDao _customerDao;
        public ICustomerDao CustomerDataObject
        {
            set => _customerDao = value;
            get
            {
                if (_customerDao == null)
                {
                    _customerDao = new CustomerDao();
                    return _customerDao;
                }
                else
                {
                    return _customerDao;
                }
            }
        }


        public CustomerResult Create(CustomerParam param)
        {

            Data.Entity.Customer entity = _customerParamConverter.Convert(param, null);

            _customerDao.Save(entity);

            return _customerResultConverter.Convert(entity);
        }

        public List<CustomerResult> Create(List<CustomerParam> param)
        {
            List<Data.Entity.Customer> entities = new List<Data.Entity.Customer>();
            foreach (var item in param)
            {
                entities.Add(_customerParamConverter.Convert(item, null));
            }
            _customerDao.Save(entities);
            List<CustomerResult> result = new List<CustomerResult>();
            foreach (var item in entities)
            {
                result.Add(_customerResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _customerDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Customer> entity = new List<Data.Entity.Customer>();
            foreach (var id in idList)
            {
                entity.Add(_customerDao.Find(id));
            }
            foreach (var id in idList)
            {
                _customerDao.Delete(id);
            }
        }

        public CustomerResult Find(long id)
        {
            try
            {
                Data.Entity.Customer entity = _customerDao.Find(id);
                CustomerResult result = _customerResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<CustomerResult> Find()
        {
            List<Data.Entity.Customer> Customers = _customerDao.Find();
            List<CustomerResult> results = new List<CustomerResult>();
            foreach (var item in Customers)
            {
                results.Add(_customerResultConverter.Convert(item));
            }
            return results;
        }

        public List<CustomerResult> FindByField(string field, string value)
        {
            List<Data.Entity.Customer> Customers = _customerDao.FindByField(field, value);
            List<CustomerResult> results = new List<CustomerResult>();
            foreach (var item in Customers)
            {
                results.Add(_customerResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, CustomerParam param)
        {
            Data.Entity.Customer oldEntity = _customerDao.Find(id);
            Data.Entity.Customer newEntity = _customerParamConverter.Convert(param, oldEntity);
            _customerDao.Update(newEntity);
        }

        public void Update(List<CustomerParam> param)
        {
            List<Data.Entity.Customer> entity = new List<Data.Entity.Customer>();
            foreach (var item in param)
            {
                Data.Entity.Customer oldEntity = _customerDao.Find(item.Id);
                Data.Entity.Customer newEntity = _customerParamConverter.Convert(item, oldEntity);
                _customerDao.Update(newEntity);
            }
        }
    }
}
