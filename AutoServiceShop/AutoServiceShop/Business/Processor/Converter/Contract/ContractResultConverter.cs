using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Contract
{
    class ContractResultConverter : BaseResultConverter<Data.Entity.Contract, ContractResult>, IContractResultConverter
    {
        public override void ConvertSpecific(Data.Entity.Contract param, ContractResult result)
        {
            result.ContractStatusId = param.ContractStatus.Id;
            result.ContractStatusName = param.ContractStatus.Name;
            result.ContractTypeId = param.ContractType.Id;
            result.ContractTypeName = param.ContractType.Name;
        }
    }
}
