using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.ContractStatus
{
    interface IContractStatusParamConverter
    {
        AutoServiceShop.Data.Entity.ContractStatus Convert(ContractStatusParam param, Data.Entity.ContractStatus oldentity);
    }
}
