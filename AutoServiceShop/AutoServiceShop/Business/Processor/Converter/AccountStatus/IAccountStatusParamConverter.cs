using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.AccountStatus
{
    interface IAccountStatusParamConverter
    {
        AutoServiceShop.Data.Entity.AccountStatus Convert(AccountStatusParam param, Data.Entity.AccountStatus oldentity);
    }
}
