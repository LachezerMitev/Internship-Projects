using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Account
{
    class AccountDaoEF : BaseDaoEF<Data.Entity.Account, long>, IAccountDao
    {
        public AccountDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
