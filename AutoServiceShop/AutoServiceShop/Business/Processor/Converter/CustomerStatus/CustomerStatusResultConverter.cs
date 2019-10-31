using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.CustomerStatus
{
    class CustomerStatusResultConverter : ICustomerStatusResultConverter
    {
        public CustomerStatusResult Convert(Data.Entity.CustomerStatus param)
        {
            CustomerStatusResult result = new CustomerStatusResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }
    }
}
