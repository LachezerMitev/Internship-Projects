using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.Converter.Make;
using AutoServiceShop.Business.Processor.Make;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.Make;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.MakeController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationMake]
    public class MakeController
        : BaseController<IMakeProcessor, IMakeParamConverter, IMakeResultConverter, MakeParam, MakeResult, IMakeDao, long, Data.Entity.Make>, IMakeController
    {
        public MakeController(IMakeProcessor processor) : base(processor)
        {
        }
    }
}
