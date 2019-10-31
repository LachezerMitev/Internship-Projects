using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.ContractType
{
    interface IContractTypeService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(ContractTypeParam param);
        ApiResponse Create(List<ContractTypeParam> param);

        ApiResponse Update(long id, ContractTypeParam param);
        ApiResponse Update(List<ContractTypeParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(ContractTypeParam param);
        void ValidateParameters(List<ContractTypeParam> param);
    }
}
