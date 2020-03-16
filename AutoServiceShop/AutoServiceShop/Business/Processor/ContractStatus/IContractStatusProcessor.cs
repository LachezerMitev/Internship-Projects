using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.ContractStatus
{
    public interface IContractStatusProcessor
        : IBaseProcessor<IContractStatusParamConverter, IContractStatusResultConverter, ContractStatusParam, ContractStatusResult, IContractStatusDao, long, Data.Entity.ContractStatus>
    {
    }
}
