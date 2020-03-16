using AutoServiceShop.Business.Processor.AccountStatus;
using AutoServiceShop.Business.Processor.Converter.AccountStatus;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.AccountStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.AccountStatusController
{
    interface IAccountStatusController
        : IBaseController<IAccountStatusProcessor, IAccountStatusParamConverter, IAccountStatusResultConvert, AccountStatusParam, AccountStatusResult, IAccountStatusDao, long, Data.Entity.AccountStatus>
    {
    }
}
