using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Dataaccess.Dao.UserGroupStatus
{
    class UserGroupStatusDaoFile : BaseDaoFile<Data.Entity.UserGroupStatus, long, UserGroupStatusStorage>, IUserGroupStatusDao
    {
        protected override long GetPK(Data.Entity.UserGroupStatus entity) => entity.Id;
    }
}
