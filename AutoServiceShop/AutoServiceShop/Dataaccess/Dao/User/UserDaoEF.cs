using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;

namespace AutoServiceShop.Dataaccess.Dao.User
{
    class UserDaoEF : BaseDaoEF<Data.Entity.User, long>, IUserDao
    {
        public UserDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
