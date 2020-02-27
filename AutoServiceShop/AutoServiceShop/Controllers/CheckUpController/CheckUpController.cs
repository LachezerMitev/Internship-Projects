using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.CheckUp;
using AutoServiceShop.Business.Processor.Converter.CheckUp;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.CheckUp;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.CheckUpController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationCheckUp]
    public class CheckUpController
        : BaseController<ICheckUpProcessor, ICheckUpParamConverter, ICheckUpResultConverter, CheckUpParam, CheckUpResult, ICheckUpDao, long, Data.Entity.CheckUp>, ICheckUpController
    {
        public CheckUpController(ICheckUpProcessor processor) : base(processor)
        {
        }
    }
}
