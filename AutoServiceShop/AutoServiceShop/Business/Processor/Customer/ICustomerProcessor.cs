using AutoServiceShop.Business.Processor.Converter.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Customer
{
    interface ICustomerProcessor
    {
        CustomerResult Create(CustomerParam param);
        List<CustomerResult> Create(List<CustomerParam> param);

        void Update(long id, CustomerParam param);
        void Update(List<CustomerParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        CustomerResult Find(long id);
        List<CustomerResult> Find();
    }
}
