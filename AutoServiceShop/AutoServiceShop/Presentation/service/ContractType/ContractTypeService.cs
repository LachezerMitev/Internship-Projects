using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.ContractType;
using AutoServiceShop.Business.Processor.Converter.ContractType;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.ContractType
{
    class ContractTypeService : IContractTypeService
    {
        ContractTypeProcessor ContractTypeProcessor { get; set; }

        public ApiResponse Create(ContractTypeParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<ContractTypeParam> param)
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

        public ApiResponse Update(long id, ContractTypeParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<ContractTypeParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(ContractTypeParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<ContractTypeParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
