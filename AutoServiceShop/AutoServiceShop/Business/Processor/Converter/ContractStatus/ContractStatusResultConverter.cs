using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.ContractStatus
{
    class ContractStatusResultConverter : BaseResultConverter<Data.Entity.ContractStatus, ContractStatusResult>, IContractStatusResultConverter
    {
        public ContractStatusResult Convert(Data.Entity.ContractStatus param)
        {
            ContractStatusResult result = new ContractStatusResult();

            ConverterStandart(param, result);

            return result;
        }

        public override ContractStatusResult ConvertSpecific(Data.Entity.ContractStatus param, ContractStatusResult result)
        {
            throw new NotImplementedException();
        }
    }
}
