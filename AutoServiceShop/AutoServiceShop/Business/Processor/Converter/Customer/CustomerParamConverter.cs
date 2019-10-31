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
        ICustomerDao CustomerDao = new CustomerDao();
        ICustomerStatusDao CustomerStatusDao = new CustomerStatusDao();

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

            entity.CustomerStatus = CustomerStatusDao.Find(param.CustomerStatusId);

            return entity;
        }
    }
}
