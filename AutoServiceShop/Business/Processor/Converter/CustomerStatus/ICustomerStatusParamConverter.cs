using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.CustomerStatus
{
    interface ICustomerStatusParamConverter
    {
        AutoServiceShop.Data.Entity.CustomerStatus Convert(CustomerStatusParam param);
    }
}
