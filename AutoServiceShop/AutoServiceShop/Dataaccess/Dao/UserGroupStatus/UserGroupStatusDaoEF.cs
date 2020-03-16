using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.UserGroupStatus
{
    class UserGroupStatusDaoEF : BaseDaoEF<Data.Entity.UserGroupStatus, long>, IUserGroupStatusDao
    {
        public UserGroupStatusDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
