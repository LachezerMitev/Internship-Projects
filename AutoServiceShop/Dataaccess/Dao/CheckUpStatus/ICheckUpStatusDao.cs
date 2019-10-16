using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.CheckUpStatus
{
    interface ICheckUpStatusDao
    {
        Data.Entity.CheckUpStatus Save(Data.Entity.CheckUpStatus entity);
        List<Data.Entity.CheckUpStatus> Save(List<Data.Entity.CheckUpStatus> entity);

        Data.Entity.CheckUpStatus Update(Data.Entity.CheckUpStatus entity);
        List<Data.Entity.CheckUpStatus> Update(List<Data.Entity.CheckUpStatus> entity);

        void Delete(long id);
        void Delete(Data.Entity.CheckUpStatus entity);
        void Delete(List<long> idList);

        List<Data.Entity.CheckUpStatus> Find();
        Data.Entity.CheckUpStatus Find(long id);
    }
}
