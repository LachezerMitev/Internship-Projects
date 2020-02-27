using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.AccountType;
using AutoServiceShop.Business.Processor.Converter.AccountType;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.AccountType;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.AccountTypeController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationAccountType]
    public class AccountTypeController
        : BaseController<IAccountTypeProcessor, IAccountTypeParamConverter, IAccountTypeResultConverter, AccountTypeParam, AccountTypeResult, IAccountTypeDao, long, Data.Entity.AccountType>, IAccountTypeController
    {
        public AccountTypeController(IAccountTypeProcessor processor) : base(processor)
        {
        }
    }
}
