using AutoServiceShop.Business.Processor.Converter.CustomerStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.CustomerStatus
{
    interface ICustomerStatusProcessor
    {
        CustomerStatusResult Create(CustomerStatusParam param);
        List<CustomerStatusResult> Create(List<CustomerStatusParam> param);

        void Update(long id, CustomerStatusParam param);
        void Update(List<CustomerStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        CustomerStatusResult Find(long id);
        List<CustomerStatusResult> Find();
    }
}
