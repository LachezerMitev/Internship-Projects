using AutoServiceShop.Business.Processor.Contract;
using AutoServiceShop.Business.Processor.Converter.Contract;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.ContractController
{
    interface IContractController
        : IBaseController<IContractProcessor, IContractParamconverter, IContractResultConverter, ContractParam, ContractResult, IContractDao, long, Data.Entity.Contract>
    {
    }
}
