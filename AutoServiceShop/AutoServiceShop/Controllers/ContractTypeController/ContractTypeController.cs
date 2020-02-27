using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.ContractType;
using AutoServiceShop.Business.Processor.Converter.ContractType;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.ContractType;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.ContractTypeController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationContractType]
    public class ContractTypeController
        : BaseController<IContractTypeProcessor, IContractTypeParamConverter, IContractTypeResultConverter, ContractTypeParam, ContractTypeResult, IContractTypeDao, long, Data.Entity.ContractType>, IContractTypeController

    {
        public ContractTypeController(IContractTypeProcessor processor) : base(processor)
        {
        }
    }
}
