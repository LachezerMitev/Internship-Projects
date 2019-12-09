using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Make
{
    interface IMakeDao
    {
        Data.Entity.Make Save(Data.Entity.Make entity);
        List<Data.Entity.Make> Save(List<Data.Entity.Make> entity);

        Data.Entity.Make Update(Data.Entity.Make entity);
        List<Data.Entity.Make> Update(List<Data.Entity.Make> entity);

        void Delete(long id);
        void Delete(Data.Entity.Make entity);
        void Delete(List<long> idList);

        List<Data.Entity.Make> Find();
        Data.Entity.Make Find(long id);
        List<Data.Entity.Make> FindByField(string field, string value);
    }
}
