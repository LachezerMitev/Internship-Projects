using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.AccountStatus;
using AutoServiceShop.Business.Processor.Converter.AccountStatus;
using AutoServiceShop.Data.Common;
using AutoServiceShop.Dataaccess.Dao.AccountStatus;
using AutoServiceShop.Presentation.service.Common;

namespace AutoServiceShop.Presentation.service.AccountStatus
{
    class AccountStatusService
        : BaseService<IAccountStatusProcessor, IAccountStatusParamConverter, IAccountStatusResultConvert, AccountStatusParam, AccountStatusResult, IAccountStatusDao, long, Data.Entity.AccountStatus>, IAccountStatusService
    {
        
    }
}
