using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Dataaccess.Dao.UserUserGroup
{
    class UserUserGroupDaoFile : BaseDaoFile<Data.Entity.UserUserGroup, long, UserUserGroupStorage>, IUserUserGroupDao
    {
        protected override long GetPK(Data.Entity.UserUserGroup entity) => entity.Id;
    }
}
