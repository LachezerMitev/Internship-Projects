using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.UserGroup
{
    class UserGroupDaoEF : BaseDaoEF<Data.Entity.UserGroup, long>, IUserGroupDao
    {
        public UserGroupDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
