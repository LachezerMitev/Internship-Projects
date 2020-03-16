using AutoServiceShop.Business.Processor.ContractType;
using AutoServiceShop.Business.Processor.Converter.ContractType;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.ContractTypeController
{
    interface IContractTypeController
        : IBaseController<IContractTypeProcessor, IContractTypeParamConverter, IContractTypeResultConverter, ContractTypeParam, ContractTypeResult, IContractTypeDao, long, Data.Entity.ContractType>
    {
    }
}
