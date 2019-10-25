using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.Contract
{
    interface IContractService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(ContractParam param);
        ApiResponse Create(List<ContractParam> param);

        ApiResponse Update(long id, ContractParam param);
        ApiResponse Update(List<ContractParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(ContractParam param);
        void ValidateParameters(List<ContractParam> param);
    }
}
