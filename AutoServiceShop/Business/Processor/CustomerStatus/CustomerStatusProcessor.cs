using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.CustomerStatus;
using AutoServiceShop.Business.Processor.Converter.CustomerStatus;

namespace AutoServiceShop.Business.Processor.CustomerStatus
{
    class CustomerStatusProcessor : ICustomerStatusProcessor
    {
        ICustomerStatusDao CustomerStatusDao { get; set; }

        ICustomerStatusParamConverter CustomerStatusParamConverter { get; set; }
        ICustomerStatusResultConverter CustomerStatusResultConverter { get; set; }

        public CustomerStatusResult Create(CustomerStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<CustomerStatusResult> Create(List<CustomerStatusParam> param)
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

        public CustomerStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, CustomerStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<CustomerStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
