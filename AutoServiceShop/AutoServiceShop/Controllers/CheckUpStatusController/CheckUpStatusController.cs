using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.CheckUpStatus;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.CheckUpStatusController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationCheckUpStatus]
    public class CheckUpStatusController
        : BaseController<ICheckUpStatusProcessor, ICheckUpStatusParamConverter, ICheckUpStatusResultConverter, CheckUpStatusParam, CheckUpStatusResult, ICheckUpStatusDao, long, Data.Entity.CheckUpStatus>, ICheckUpStatusController

    {
        public CheckUpStatusController(ICheckUpStatusProcessor processor) : base(processor)
        {
        }
    }
}
