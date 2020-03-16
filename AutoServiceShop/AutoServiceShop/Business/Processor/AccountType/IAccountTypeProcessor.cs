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
    public interface IAccountTypeProcessor
        : IBaseProcessor<IAccountTypeParamConverter, IAccountTypeResultConverter, AccountTypeParam, AccountTypeResult, IAccountTypeDao, long, Data.Entity.AccountType>
    {
    }
}
