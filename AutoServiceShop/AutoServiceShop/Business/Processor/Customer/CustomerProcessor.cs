using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Customer;
using AutoServiceShop.Business.Processor.Converter.Customer;

namespace AutoServiceShop.Business.Processor.Customer
{
    class CustomerProcessor : ICustomerProcessor
    {
        CustomerDao CustomerDao { get; set; }

        CustomerParamConverter CustomerParamConverter { get; set; }
        CustomerResultConverter CustomerResultConverter { get; set; }

        public CustomerResult Create(CustomerParam param)
        {
            throw new NotImplementedException();
        }

        public List<CustomerResult> Create(List<CustomerParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public CustomerResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, CustomerParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<CustomerParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
