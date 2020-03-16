using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.UserUserGroup
{
    class UserUserGroupDaoEF : BaseDaoEF<Data.Entity.UserUserGroup, long>, IUserUserGroupDao
    {
        public UserUserGroupDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
