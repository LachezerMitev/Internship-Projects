using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.User
{
    interface IUserDao
    {
        Data.Entity.User Save(Data.Entity.User entity);
        List<Data.Entity.User> Save(List<Data.Entity.User> entity);

        Data.Entity.User Update(Data.Entity.User entity);
        List<Data.Entity.User> Update(List<Data.Entity.User> entity);

        void Delete(long id);
        void Delete(Data.Entity.User entity);
        void Delete(List<long> idList);

        List<Data.Entity.User> Find();
        Data.Entity.User Find(long id);
        List<Data.Entity.User> FindByField(string field, string value);
    }
}
