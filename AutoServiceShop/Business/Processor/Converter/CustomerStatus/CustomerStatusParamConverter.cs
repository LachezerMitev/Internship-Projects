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
        ICustomerStatusDao CustomerStatusDao { get; set; }

        public Data.Entity.CustomerStatus Convert(CustomerStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
