using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.CustomerStatus;
using AutoServiceShop.Business.Processor.CustomerStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.CustomerStatus
{
    class CustomerStatusService : ICustomerStatusService
    {
        ICustomerStatusProcessor CustomerStatusProcessor { get; set; }

        public ApiResponse Create(CustomerStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<CustomerStatusParam> param)
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

        public ApiResponse Update(long id, CustomerStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<CustomerStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(CustomerStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<CustomerStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
