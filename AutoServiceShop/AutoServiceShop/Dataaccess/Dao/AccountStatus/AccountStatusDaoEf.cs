using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AccountStatus
{
    class AccountStatusDaoEF : BaseDaoEF<Data.Entity.AccountStatus, long>, IAccountStatusDao
    {
        public AccountStatusDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
