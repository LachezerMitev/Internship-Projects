using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.Customer
{
    interface ICustomerService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(CustomerParam param);
        ApiResponse Create(List<CustomerParam> param);

        ApiResponse Update(long id, CustomerParam param);
        ApiResponse Update(List<CustomerParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(CustomerParam param);
        void ValidateParameters(List<CustomerParam> param);
    }
}
