using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.Account;
using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.Account;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.AccountController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationAccount]
    public class AccountController
        : BaseController<IAccountProcessor, IAccountParamConverter, IAccountResultConverter, AccountParam, AccountResult, IAccountDao, long, Data.Entity.Account>, IAccountController
    {
        public AccountController(IAccountProcessor processor) : base(processor)
        {
        }
    }
}
