using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Dataaccess.Dao.UserGroup
{
    class UserGroupDaoFile : BaseDaoFile<Data.Entity.UserGroup, long, UserGroupStorage>, IUserGroupDao
    {
        
    }
}
