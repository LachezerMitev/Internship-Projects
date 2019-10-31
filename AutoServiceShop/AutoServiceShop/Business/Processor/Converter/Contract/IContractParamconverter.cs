using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Contract
{
    interface IContractParamconverter
    {
        AutoServiceShop.Data.Entity.Contract Convert(ContractParam param, Data.Entity.Contract oldentity);
    }
}
