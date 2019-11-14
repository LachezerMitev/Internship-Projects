using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.ContractType
{
    class ContractTypeResultConverter : BaseResultConverter<Data.Entity.ContractType, ContractTypeResult>, IContractTypeResultConverter
    {
        public ContractTypeResult Convert(Data.Entity.ContractType param)
        {
            ContractTypeResult result = new ContractTypeResult();

            ConverterStandart(param, result);

            return result;
        }

        public override ContractTypeResult ConvertSpecific(Data.Entity.ContractType param, ContractTypeResult result)
        {
            throw new NotImplementedException();
        }
    }
}
