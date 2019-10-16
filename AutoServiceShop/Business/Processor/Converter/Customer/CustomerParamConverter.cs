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
        CustomerDao CustomerDao { get; set; }

        public Data.Entity.Customer Convert(CustomerParam param)
        {
            throw new NotImplementedException();
        }
    }
}
