using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.ContractStatus;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.ContractStatusController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationContractStatus]
    public class ContractStatusController
        : BaseController<IContractStatusProcessor, IContractStatusParamConverter, IContractStatusResultConverter, ContractStatusParam, ContractStatusResult, IContractStatusDao, long, Data.Entity.ContractStatus>, IContractStatusController
    {
        public ContractStatusController(IContractStatusProcessor processor) : base(processor)
        {
        }
    }
}
