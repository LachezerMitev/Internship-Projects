using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.CustomerStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.CustomerStatus
{
    interface ICustomerStatusService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(CustomerStatusParam param);
        ApiResponse Create(List<CustomerStatusParam> param);

        ApiResponse Update(long id, CustomerStatusParam param);
        ApiResponse Update(List<CustomerStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(CustomerStatusParam param);
        void ValidateParameters(List<CustomerStatusParam> param);
    }
}
