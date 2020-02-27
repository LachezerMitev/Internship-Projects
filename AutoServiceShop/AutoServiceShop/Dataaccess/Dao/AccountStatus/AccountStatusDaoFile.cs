using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Dataaccess.Dao.AccountStatus
{
    class AccountStatusDaoFile
        : BaseDaoFile<Data.Entity.AccountStatus, long, AccountStatusStorage>, IAccountStatusDao
    {
        protected override long GetPK(Data.Entity.AccountStatus entity) => entity.Id;
    }
}
