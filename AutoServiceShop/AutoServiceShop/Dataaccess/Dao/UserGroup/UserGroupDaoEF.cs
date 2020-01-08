using AutoServiceShop.Dataaccess.Dao.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.UserGroup
{
    class UserGroupDaoEF : BaseDaoEF<Data.Entity.UserGroup, long>, IUserGroupDao
    {
    }
}
