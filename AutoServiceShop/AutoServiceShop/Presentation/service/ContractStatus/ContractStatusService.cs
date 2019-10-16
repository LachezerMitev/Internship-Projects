using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.ContractStatus;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.ContractStatus
{
    class ContractStatusService : IContractStatusService
    {
        ContractStatusProcessor ContractStatusProcessor { get; set; }

        public ApiResponse Create(ContractStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<ContractStatusParam> param)
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

        public ApiResponse Update(long id, ContractStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<ContractStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(ContractStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<ContractStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
