using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AccountStatus
{
    interface IAccountStatusDao
    {
        Data.Entity.AccountStatus Save(Data.Entity.AccountStatus entity);
        List<Data.Entity.AccountStatus> Save(List<Data.Entity.AccountStatus> entity);

        Data.Entity.AccountStatus Update(Data.Entity.AccountStatus entity);
        List<Data.Entity.AccountStatus> Update(List<Data.Entity.AccountStatus> entity);

        void Delete(long id);
        void Delete(Data.Entity.AccountStatus entity);
        void Delete(List<long> idList);

        List<Data.Entity.AccountStatus> Find();
        Data.Entity.AccountStatus Find(long id);
    }
}
