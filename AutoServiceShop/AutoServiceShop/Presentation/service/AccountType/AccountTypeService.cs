using AutoServiceShop.Business.Processor.AccountType;
using AutoServiceShop.Business.Processor.Converter.AccountType;
using AutoServiceShop.Data.Common;
using AutoServiceShop.Dataaccess.Dao.AccountType;
using AutoServiceShop.Presentation.service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.AccountType
{
    public class AccountTypeService
        : BaseService<IAccountTypeProcessor, IAccountTypeParamConverter, IAccountTypeResultConverter, AccountTypeParam, AccountTypeResult, IAccountTypeDao, long, Data.Entity.AccountType>, IAccountTypeService
    {
        
    }
}
