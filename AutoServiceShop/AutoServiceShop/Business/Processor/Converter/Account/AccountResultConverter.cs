using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Account
{
    class AccountResultConverter : BaseResultConverter<Data.Entity.Account, AccountResult>, IAccountResultConverter
    {
        public override void ConvertSpecific(Data.Entity.Account param, AccountResult result)
        {
<<<<<<< Updated upstream
            
            AccountResult result = new AccountResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,
                FirstName = param.FirstName,
                Surname = param.Surname,
                LastName = param.LastName,
                Type = param.Type,

                AccountStatusId = param.AccountStatus.Id,
                UserId = param.User.Id,
                AccountStatusName = param.AccountStatus.Name,
                Username = param.User.Username
                
            };

            return result;
=======
            if (param.AccountStatus == null || param.User == null || param.AccountType == null)
                throw new Exception("Some or all items in the entity taht are crucial were not found");

            result.AccountStatusId = param.AccountStatus.Id;
            result.AccountStatusName = param.AccountStatus.Name;
            result.UserId = param.User.Id;
            result.UserName = param.User.Username;
            result.AccountTypeId = param.AccountType.Id;
            result.AccountTypeName = param.AccountType.Name;
>>>>>>> Stashed changes
        }
    }
}
