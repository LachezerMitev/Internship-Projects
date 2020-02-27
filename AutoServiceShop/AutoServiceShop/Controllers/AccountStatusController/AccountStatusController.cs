using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.AccountStatus;
using AutoServiceShop.Business.Processor.Converter.AccountStatus;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.AccountStatus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.AccountStatusController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationAccountStatus]
    public class AccountStatusController
        : BaseController<IAccountStatusProcessor, IAccountStatusParamConverter, IAccountStatusResultConvert, AccountStatusParam, AccountStatusResult, IAccountStatusDao, long, Data.Entity.AccountStatus>, IAccountStatusController
    {
        public AccountStatusController(IAccountStatusProcessor processor) : base(processor)
        {
        }
    }
}
