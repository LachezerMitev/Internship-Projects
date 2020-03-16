using AutoServiceShop.Dataaccess.Dao.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.UserGroupStatus
{
    public interface IUserGroupStatusDao : IBaseDao<Data.Entity.UserGroupStatus, long>
    {
<<<<<<< Updated upstream
        Data.Entity.UserGroupStatus Save(Data.Entity.UserGroupStatus entity);
        List<Data.Entity.UserGroupStatus> Save(List<Data.Entity.UserGroupStatus> entity);

        Data.Entity.UserGroupStatus Update(Data.Entity.UserGroupStatus entity);
        List<Data.Entity.UserGroupStatus> Update(List<Data.Entity.UserGroupStatus> entity);

        void Delete(long id);
        void Delete(Data.Entity.UserGroupStatus entity);
        void Delete(List<long> idList);

        List<Data.Entity.UserGroupStatus> Find();
        Data.Entity.UserGroupStatus Find(long id);
=======
>>>>>>> Stashed changes
    }
}
