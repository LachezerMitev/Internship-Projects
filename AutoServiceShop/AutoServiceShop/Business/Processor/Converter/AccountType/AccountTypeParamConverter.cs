using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.AccountType
{
    class AccountTypeParamConvert : BaseParamConverter<AccountTypeParam, Data.Entity.AccountType>, IAccountTypeParamConverter
    {
        public override void ConvertSpecific(AccountTypeParam param, Data.Entity.AccountType entity)
        {
        }

        public override Data.Entity.AccountType GetResult(AccountTypeParam param)
        {
            Data.Entity.AccountType entity = new Data.Entity.AccountType
            {
                Code = param.Code,
                Id = param.Id,
            };

            return entity;
        }
    }
}
