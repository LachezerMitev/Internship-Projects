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

        public override void ConvertSpecific(Data.Entity.AccountStatus param, AccountStatusResult result) { }
    }
}
