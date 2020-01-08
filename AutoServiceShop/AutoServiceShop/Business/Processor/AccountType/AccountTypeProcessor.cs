using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.AccountType;
using AutoServiceShop.Dataaccess.Dao.AccountType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.AccountType
{
    public class AccountTypeProcessor
        : BaseProcessor<IAccountTypeParamConverter, IAccountTypeResultConverter, AccountTypeParam, AccountTypeResult, IAccountTypeDao, long, Data.Entity.AccountType>, IAccountTypeProcessor
    {
    }
}
