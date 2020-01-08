using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.ContractStatus;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;

namespace AutoServiceShop.Presentation.service.ContractStatus
{
    public interface IContractStatusService
        : IBaseService<IContractStatusProcessor, IContractStatusParamConverter, IContractStatusResultConverter, ContractStatusParam, ContractStatusResult, IContractStatusDao, long, Data.Entity.ContractStatus>
    {
    }
}
