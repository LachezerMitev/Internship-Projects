using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using Newtonsoft.Json;

namespace AutoServiceShop.Business.Processor.Converter.Account
{
    class AccountResultConverter : BaseResultConverter<Data.Entity.Account, AccountResult>, IAccountResultConverter
    {
        public override void ConvertSpecific(Data.Entity.Account param, AccountResult result)
        {
            result.AccountStatusId = param.AccountStatus.Id;
            result.AccountStatusName = param.AccountStatus.Name;
            result.UserId = param.User.Id;
            result.UserName = param.User.Username;
            result.AccountTypeId = param.AccountType.Id;
            result.AccountTypeName = param.AccountType.Name;
        }
    }
}
