using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.CustomerStatus
{
    class CustomerStatusResultConverter : BaseResultConverter<Data.Entity.CustomerStatus, CustomerStatusResult>, ICustomerStatusResultConverter
    {
        public CustomerStatusResult Convert(Data.Entity.CustomerStatus param)
        {
            CustomerStatusResult result = new CustomerStatusResult();

            ConverterStandart(param, result);

            return result;
        }

        public override CustomerStatusResult ConvertSpecific(Data.Entity.CustomerStatus param, CustomerStatusResult result)
        {
            throw new NotImplementedException();
        }
    }
}
