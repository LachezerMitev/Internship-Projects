using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Contract
{
    interface IContractResultConverter
    {
        ContractResult Convert(AutoServiceShop.Data.Entity.Contract param);
    }
}
