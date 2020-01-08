using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.ContractType;
using AutoServiceShop.Dataaccess.Dao.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.ContractType
{
    public interface IContractTypeProcessor
        : IBaseProcessor<IContractTypeParamConverter, IContractTypeResultConverter, ContractTypeParam, ContractTypeResult, IContractTypeDao, long, Data.Entity.ContractType>
    {
    }
}
