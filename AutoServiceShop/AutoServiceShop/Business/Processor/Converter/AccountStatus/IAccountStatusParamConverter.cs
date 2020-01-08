using AutoServiceShop.Business.Processor.Converter.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.AccountStatus
{
    public interface IAccountStatusParamConverter : IBaseParamConverter<AccountStatusParam, Data.Entity.AccountStatus>
    {
        //AutoServiceShop.Data.Entity.AccountStatus Convert(AccountStatusParam param, Data.Entity.AccountStatus oldentity);
    }
}
