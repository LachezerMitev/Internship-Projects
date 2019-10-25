using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.ContractStatus
{
    interface IContractStatusService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(ContractStatusParam param);
        ApiResponse Create(List<ContractStatusParam> param);

        ApiResponse Update(long id, ContractStatusParam param);
        ApiResponse Update(List<ContractStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(ContractStatusParam param);
        void ValidateParameters(List<ContractStatusParam> param);
    }
}
