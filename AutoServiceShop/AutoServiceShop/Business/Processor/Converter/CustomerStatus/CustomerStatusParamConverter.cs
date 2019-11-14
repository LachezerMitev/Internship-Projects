using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.CustomerStatus;

namespace AutoServiceShop.Business.Processor.Converter.CustomerStatus
{
    class CustomerStatusParamConverter : BaseParamConverter<CustomerStatusParam, Data.Entity.CustomerStatus>, ICustomerStatusParamConverter
    {
        ICustomerStatusDao CustomerStatusDao = new CustomerStatusDao();

        public Data.Entity.CustomerStatus Convert(CustomerStatusParam param, Data.Entity.CustomerStatus oldentity)
        {
            Data.Entity.CustomerStatus entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.CustomerStatus
                {
                    Code = param.Code,
                    Id = param.Id
                };
            }

            ConverterStandart(param, entity);

            return entity;
        }

        public override Data.Entity.CustomerStatus ConvertSpecific(CustomerStatusParam param, Data.Entity.CustomerStatus entity)
        {
            throw new NotImplementedException();
        }
    }
}
