using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.Contract;
using AutoServiceShop.Dataaccess.Dao.Contract;

namespace AutoServiceShop.Presentation.service.Contract
{
    public interface IContractService
        : IBaseService<IContractProcessor, IContractParamconverter, IContractResultConverter, ContractParam, ContractResult, IContractDao, long, Data.Entity.Contract>
    {
    }
}
