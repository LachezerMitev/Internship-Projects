using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.Contract;
using AutoServiceShop.Business.Processor.Converter.Contract;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.Contract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.ContractController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationContract]
    public class ContractController
        : BaseController<IContractProcessor, IContractParamconverter, IContractResultConverter, ContractParam, ContractResult, IContractDao, long, Data.Entity.Contract>, IContractController
    {
        public ContractController(IContractProcessor processor) : base(processor)
        {
        }
    }
}
