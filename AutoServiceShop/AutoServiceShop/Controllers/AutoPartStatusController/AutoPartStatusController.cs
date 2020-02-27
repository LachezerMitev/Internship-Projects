using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.AutoPartStatus;
using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.AutoPartStatusController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationAutoPartStatus]
    public class AutoPartStatusController
        : BaseController<IAutoPartStatusProcessor, IAutoPartStatusParamConverter, IAutoPartStatusResultConverter, AutoPartStatusParam, AutoPartStatusResult, IAutoPartStatusDao, long, Data.Entity.AutoPartStatus>, IAutoPartStatusController
    {
        public AutoPartStatusController(IAutoPartStatusProcessor processor) : base(processor)
        {
        }
    }
}
