using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Account
{
    interface IAccountDao
    {
        Data.Entity.Account Save(Data.Entity.Account entity);
        List<Data.Entity.Account> Save(List<Data.Entity.Account> entity);

        Data.Entity.Account Update(Data.Entity.Account entity);
        List<Data.Entity.Account> Update(List<Data.Entity.Account> entity);

        void Delete(long id);
        void Delete(Data.Entity.Account entity);
        void Delete(List<long> idList);

        List<Data.Entity.Account> Find();
        Data.Entity.Account Find(long id);
        List<Data.Entity.Account> FindByField(string field, string value);
    }
}
