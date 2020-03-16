using AutoServiceShop.Business.Processor.ContractStatus;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.ContractStatusController
{
    interface IContractStatusController
        : IBaseController<IContractStatusProcessor, IContractStatusParamConverter, IContractStatusResultConverter, ContractStatusParam, ContractStatusResult, IContractStatusDao, long, Data.Entity.ContractStatus>
    {
    }
}
