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
        public override void ConvertSpecific(Data.Entity.ContractType param, ContractTypeResult result)
        {
            throw new NotImplementedException();
        }
    }
}
