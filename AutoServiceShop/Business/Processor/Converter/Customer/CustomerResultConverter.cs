using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Customer
{
    class CustomerResultConverter : ICustomerResultConverter
    {
        public CustomerResult Convert(Data.Entity.Customer param)
        {
            CustomerResult result = new CustomerResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,
                CustomerStatus = param.CustomerStatus
            };

            return result;
        }
    }
}
