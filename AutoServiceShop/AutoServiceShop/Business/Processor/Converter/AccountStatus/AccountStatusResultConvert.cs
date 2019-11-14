using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.AccountStatus
{
    class AccountStatusResultConvert : BaseResultConverter<Data.Entity.AccountStatus, AccountStatusResult>, IAccountStatusResultConvert
    {
        public AccountStatusResult Convert(Data.Entity.AccountStatus param)
        {
            AccountStatusResult result = new AccountStatusResult();

            ConverterStandart(param, result);

            return result;
        }

        public override AccountStatusResult ConvertSpecific(Data.Entity.AccountStatus param, AccountStatusResult result)
        {
            throw new NotImplementedException();
        }
    }
}
