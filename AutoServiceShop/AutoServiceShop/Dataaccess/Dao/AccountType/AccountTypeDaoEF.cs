using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AccountType
{
    class AccountTypeDaoEF : BaseDaoEF<Data.Entity.AccountType, long>, IAccountTypeDao
    {
        public AccountTypeDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
