using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.CustomerStatus;

namespace AutoServiceShop.Business.Processor.Converter.CustomerStatus
{
    class CustomerStatusParamConverter : ICustomerStatusParamConverter
    {
        ICustomerStatusDao CustomerStatusDao = new CustomerStatusDao();

        public Data.Entity.CustomerStatus Convert(CustomerStatusParam param, Data.Entity.CustomerStatus oldentity)
        {
            Data.Entity.CustomerStatus entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.CustomerStatus
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }
            
            return entity;
        }
    }
}
