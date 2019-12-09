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
        private ICustomerStatusParamConverter _customerStatusParamConverter;
        public ICustomerStatusParamConverter CustomerStatusParamConverter
        {
            set => _customerStatusParamConverter = value;
            get
            {
                if (_customerStatusParamConverter == null)
                {
                    _customerStatusParamConverter = new CustomerStatusParamConverter();
                    return _customerStatusParamConverter;
                }
                else
                {
                    return _customerStatusParamConverter;
                }
            }
        }

        private ICustomerStatusResultConverter _customerStatusResultConverter;
        public ICustomerStatusResultConverter CustomerStatusResultConverter
        {
            set => _customerStatusResultConverter = value;
            get
            {
                if (_customerStatusResultConverter == null)
                {
                    _customerStatusResultConverter = new CustomerStatusResultConverter();
                    return _customerStatusResultConverter;
                }
                else
                {
                    return _customerStatusResultConverter;
                }
            }
        }

        private ICustomerStatusDao _customerStatusDao;
        public ICustomerStatusDao CustomerStatusDataObject
        {
            set => _customerStatusDao = value;
            get
            {
                if (_customerStatusDao == null)
                {
                    _customerStatusDao = new CustomerStatusDao();
                    return _customerStatusDao;
                }
                else
                {
                    return _customerStatusDao;
                }
            }
        }


        public CustomerStatusResult Create(CustomerStatusParam param)
        {

            Data.Entity.CustomerStatus entity = _customerStatusParamConverter.Convert(param, null);

            _customerStatusDao.Save(entity);

            return _customerStatusResultConverter.Convert(entity);
        }

        public List<CustomerStatusResult> Create(List<CustomerStatusParam> param)
        {
            List<Data.Entity.CustomerStatus> entities = new List<Data.Entity.CustomerStatus>();
            foreach (var item in param)
            {
                entities.Add(_customerStatusParamConverter.Convert(item, null));
            }
            _customerStatusDao.Save(entities);
            List<CustomerStatusResult> result = new List<CustomerStatusResult>();
            foreach (var item in entities)
            {
                result.Add(_customerStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _customerStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.CustomerStatus> entity = new List<Data.Entity.CustomerStatus>();
            foreach (var id in idList)
            {
                entity.Add(_customerStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                _customerStatusDao.Delete(id);
            }
        }

        public CustomerStatusResult Find(long id)
        {
            try
            {
                Data.Entity.CustomerStatus entity = _customerStatusDao.Find(id);
                CustomerStatusResult result = _customerStatusResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<CustomerStatusResult> Find()
        {
            List<Data.Entity.CustomerStatus> CustomerStatuss = _customerStatusDao.Find();
            List<CustomerStatusResult> results = new List<CustomerStatusResult>();
            foreach (var item in CustomerStatuss)
            {
                results.Add(_customerStatusResultConverter.Convert(item));
            }
            return results;
        }

        public List<CustomerStatusResult> FindByField(string field, string value)
        {
            List<Data.Entity.CustomerStatus> CustomerStatuss = _customerStatusDao.FindByField(field, value);
            List<CustomerStatusResult> results = new List<CustomerStatusResult>();
            foreach (var item in CustomerStatuss)
            {
                results.Add(_customerStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, CustomerStatusParam param)
        {
            Data.Entity.CustomerStatus oldEntity = _customerStatusDao.Find(id);
            Data.Entity.CustomerStatus newEntity = _customerStatusParamConverter.Convert(param, oldEntity);
            _customerStatusDao.Update(newEntity);
        }

        public void Update(List<CustomerStatusParam> param)
        {
            List<Data.Entity.CustomerStatus> entity = new List<Data.Entity.CustomerStatus>();
            foreach (var item in param)
            {
                Data.Entity.CustomerStatus oldEntity = _customerStatusDao.Find(item.Id);
                Data.Entity.CustomerStatus newEntity = _customerStatusParamConverter.Convert(item, oldEntity);
                _customerStatusDao.Update(newEntity);
            }
        }
    }
}
