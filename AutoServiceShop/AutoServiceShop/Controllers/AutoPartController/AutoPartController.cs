using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.AutoPart;
using AutoServiceShop.Business.Processor.Converter.AutoPart;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.AutoPart;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.AutoPartController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationAutoPart]
    public class AutoPartController
        : BaseController<IAutoPartProcessor, IAutoPartParamConverter, IAutoPartResultConvert, AutoPartParam, AutoPartResult, IAutoPartDao, long, Data.Entity.AutoPart>, IAutoPartController
    {
        public AutoPartController(IAutoPartProcessor processor) : base(processor)
        {
        }
    }
}
