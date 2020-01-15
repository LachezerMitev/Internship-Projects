using AutoServiceShop.Business.Processor.Converter.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.AccountType
{
    class AccountTypeResultConvert : BaseResultConverter<Data.Entity.AccountType, AccountTypeResult>, IAccountTypeResultConverter
    {
        public override void ConvertSpecific(Data.Entity.AccountType param, AccountTypeResult result)
        {
        }
    }
}
