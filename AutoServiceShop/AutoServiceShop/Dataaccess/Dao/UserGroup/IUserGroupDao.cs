using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.UserGroup
{
    interface IUserGroupDao
    {
        Data.Entity.UserGroup Save(Data.Entity.UserGroup entity);
        List<Data.Entity.UserGroup> Save(List<Data.Entity.UserGroup> entity);

        Data.Entity.UserGroup Update(Data.Entity.UserGroup entity);
        List<Data.Entity.UserGroup> Update(List<Data.Entity.UserGroup> entity);

        void Delete(long id);
        void Delete(Data.Entity.UserGroup entity);
        void Delete(List<long> idList);

        List<Data.Entity.UserGroup> Find();
        Data.Entity.UserGroup Find(long id);
    }
}
