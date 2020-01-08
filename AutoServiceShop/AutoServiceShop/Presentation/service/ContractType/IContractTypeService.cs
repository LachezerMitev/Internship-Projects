using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.ContractType;
using AutoServiceShop.Dataaccess.Dao.ContractType;

namespace AutoServiceShop.Presentation.service.ContractType
{
    public interface IContractTypeService
        : IBaseService<IContractTypeProcessor, IContractTypeParamConverter, IContractTypeResultConverter, ContractTypeParam, ContractTypeResult, IContractTypeDao, long, Data.Entity.ContractType>
    {
    }
}
