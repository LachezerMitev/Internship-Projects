using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.ContractType
{
    interface IContractTypeParamConverter
    {
        AutoServiceShop.Data.Entity.ContractType Convert(ContractTypeParam param, Data.Entity.ContractType oldentity);
    }
}
