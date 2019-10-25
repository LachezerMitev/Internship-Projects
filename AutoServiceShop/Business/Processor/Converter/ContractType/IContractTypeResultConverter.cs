using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.ContractType
{
    interface IContractTypeResultConverter
    {
        ContractTypeResult Convert(AutoServiceShop.Data.Entity.ContractType param);
    }
}
