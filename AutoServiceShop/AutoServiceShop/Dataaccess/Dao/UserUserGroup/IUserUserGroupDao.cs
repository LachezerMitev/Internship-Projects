using AutoServiceShop.Dataaccess.Dao.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.UserUserGroup
{
    public interface IUserUserGroupDao : IBaseDao<Data.Entity.UserUserGroup, long>
    {
<<<<<<< Updated upstream
        Data.Entity.UserUserGroup Save(Data.Entity.UserUserGroup entity);
        List<Data.Entity.UserUserGroup> Save(List<Data.Entity.UserUserGroup> entity);

        Data.Entity.UserUserGroup Update(Data.Entity.UserUserGroup entity);
        List<Data.Entity.UserUserGroup> Update(List<Data.Entity.UserUserGroup> entity);

        void Delete(long id);
        void Delete(Data.Entity.UserUserGroup entity);
        void Delete(List<long> idList);

        List<Data.Entity.UserUserGroup> Find();
        Data.Entity.UserUserGroup Find(long id);
=======
>>>>>>> Stashed changes
    }
}
