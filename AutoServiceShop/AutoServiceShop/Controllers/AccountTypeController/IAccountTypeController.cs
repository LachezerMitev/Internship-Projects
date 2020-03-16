using AutoServiceShop.Business.Processor.AccountType;
using AutoServiceShop.Business.Processor.Converter.AccountType;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.AccountType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.AccountTypeController
{
    interface IAccountTypeController
       : IBaseController<IAccountTypeProcessor, IAccountTypeParamConverter, IAccountTypeResultConverter, AccountTypeParam, AccountTypeResult, IAccountTypeDao, long, Data.Entity.AccountType>
    {
    }
}
