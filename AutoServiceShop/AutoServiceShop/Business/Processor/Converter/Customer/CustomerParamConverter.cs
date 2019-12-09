using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Customer;
using AutoServiceShop.Dataaccess.Dao.CustomerStatus;

namespace AutoServiceShop.Business.Processor.Converter.Customer
{
    class CustomerParamConverter : ICustomerParamConverter
    {
        private ICustomerStatusDao _customerStatusDao;
        public ICustomerStatusDao CustomerStatusDao
        {

            set { _customerStatusDao = value; }

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

        public Data.Entity.Customer Convert(CustomerParam param, Data.Entity.Customer oldentity)
        {
            Data.Entity.Customer entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.Customer
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

<<<<<<< Updated upstream
            entity.CustomerStatus = CustomerStatusDao.Find(param.CustomerStatusId);
=======
            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.Customer ConvertSpecific(CustomerParam param, Data.Entity.Customer entity)
        {
            entity.CustomerStatus = _customerStatusDao.Find(param.CustomerStatusId);
>>>>>>> Stashed changes

            return entity;
        }
    }
}
