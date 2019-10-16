using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AutoPartStatus
{
    interface IAutoPartStatusDao
    {
        Data.Entity.AutoPartStatus Save(Data.Entity.AutoPartStatus entity);
        List<Data.Entity.AutoPartStatus> Save(List<Data.Entity.AutoPartStatus> entity);

        Data.Entity.AutoPartStatus Update(Data.Entity.AutoPartStatus entity);
        List<Data.Entity.AutoPartStatus> Update(List<Data.Entity.AutoPartStatus> entity);

        void Delete(long id);
        void Delete(Data.Entity.AutoPartStatus entity);
        void Delete(List<long> idList);

        List<Data.Entity.AutoPartStatus> Find();
        Data.Entity.AutoPartStatus Find(long id);
    }
}
