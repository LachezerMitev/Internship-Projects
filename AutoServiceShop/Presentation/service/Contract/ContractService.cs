using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.Contract;
using AutoServiceShop.Business.Processor.Converter.Contract;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Contract
{
    class ContractService : IContractService
    {
        IContractProcessor ContractProcessor { get; set; }

        public ApiResponse Create(ContractParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<ContractParam> param)
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

        public ApiResponse Update(long id, ContractParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<ContractParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(ContractParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<ContractParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
