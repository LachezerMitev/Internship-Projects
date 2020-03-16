using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.Contract;
using AutoServiceShop.Dataaccess.Dao.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Contract
{
    public interface IContractProcessor
        : IBaseProcessor<IContractParamconverter, IContractResultConverter, ContractParam, ContractResult, IContractDao, long, Data.Entity.Contract>
    {
    }
}
