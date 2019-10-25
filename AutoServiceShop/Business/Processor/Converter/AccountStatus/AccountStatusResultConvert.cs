using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.AccountStatus
{
    class AccountStatusResultConvert : IAccountStatusResultConvert
    {
        public AccountStatusResult Convert(Data.Entity.AccountStatus param)
        {
            AccountStatusResult result = new AccountStatusResult()
            {
                Id = param.Id,
                Code = param.Code,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }
    }
}
