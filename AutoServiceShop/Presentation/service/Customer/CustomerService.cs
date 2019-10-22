using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Customer;
using AutoServiceShop.Business.Processor.Customer;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Customer
{
    class CustomerService : ICustomerService
    {
        ICustomerProcessor CustomerProcessor { get; set; }

        public ApiResponse Create(CustomerParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<CustomerParam> param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ApiResponse DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse FindByPK(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListAll()
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(long id, CustomerParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<CustomerParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(CustomerParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<CustomerParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
