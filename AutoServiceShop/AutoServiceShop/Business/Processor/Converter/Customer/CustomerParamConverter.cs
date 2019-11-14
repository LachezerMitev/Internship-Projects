using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Customer;
using AutoServiceShop.Dataaccess.Dao.CustomerStatus;

namespace AutoServiceShop.Business.Processor.Converter.Customer
{
    class CustomerParamConverter : BaseParamConverter<CustomerParam, Data.Entity.Customer>, ICustomerParamConverter
    {
        ICustomerDao CustomerDao = new CustomerDao();
        ICustomerStatusDao CustomerStatusDao = new CustomerStatusDao();

        public Data.Entity.Customer Convert(CustomerParam param, Data.Entity.Customer oldentity)
        {
            Data.Entity.Customer entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.Customer
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.Customer ConvertSpecific(CustomerParam param, Data.Entity.Customer entity)
        {
            entity.CustomerStatus = CustomerStatusDao.Find(param.CustomerStatusId);

            return entity;
        }
    }
}
