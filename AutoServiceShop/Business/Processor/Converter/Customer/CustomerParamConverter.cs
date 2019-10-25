using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Customer;

namespace AutoServiceShop.Business.Processor.Converter.Customer
{
    class CustomerParamConverter : ICustomerParamConverter
    {
        ICustomerDao CustomerDao { get; set; }

        public Data.Entity.Customer Convert(CustomerParam param)
        {
            Data.Entity.Customer result = new Data.Entity.Customer()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,
                CustomerStatus = param.CustomerStatus
            };

            return result;
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
                entity = new Data.Entity.Customer();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;

            entity.CustomerStatus = param.CustomerStatus;

            return entity;
        }
    }
}
