using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.ContractStatus
{
    interface IContractStatusResultConverter
    {
        ContractStatusResult Convert(AutoServiceShop.Data.Entity.ContractStatus param);
    }
}
