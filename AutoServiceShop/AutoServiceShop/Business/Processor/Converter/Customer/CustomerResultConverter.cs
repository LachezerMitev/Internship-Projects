using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Customer
{
    class CustomerResultConverter : BaseResultConverter<Data.Entity.Customer, CustomerResult>, ICustomerResultConverter
    {
        public CustomerResult Convert(Data.Entity.Customer param)
        {
            CustomerResult result = new CustomerResult();

            ConverterStandart(param, result);

            ConvertSpecific(param, result);

            return result;
        }

        public override CustomerResult ConvertSpecific(Data.Entity.Customer param, CustomerResult result)
        {
            result.CustomerStatusId = param.CustomerStatus.Id;
            result.CustomerStatusName = param.CustomerStatus.Name;

            return result;
        }
    }
}
