using AutoServiceShop.Business.Processor.Converter.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Account
{
    public interface IAccountParamConverter : IBaseParamConverter<AccountParam, Data.Entity.Account>
    {
        //AutoServiceShop.Data.Entity.Account Convert(AccountParam param, Data.Entity.Account oldentity);
    }
}
