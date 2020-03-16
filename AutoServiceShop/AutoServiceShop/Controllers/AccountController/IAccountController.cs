using AutoServiceShop.Business.Processor.Account;
using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.AccountController
{
    interface IAccountController
        : IBaseController<IAccountProcessor, IAccountParamConverter, IAccountResultConverter, AccountParam, AccountResult, IAccountDao, long, Data.Entity.Account>
    {
    }
}
