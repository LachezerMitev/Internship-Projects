using AutoServiceShop.Dataaccess.Dao.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AccountType
{
    class AccountTypeDaoFile : BaseDaoFile<Data.Entity.AccountType, long, AccountTypeStorage>, IAccountTypeDao
    {
        protected override long GetPK(Data.Entity.AccountType entity) => entity.Id;
    }
}
