using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.CheckUp
{
    interface ICheckUpDao
    {
        Data.Entity.CheckUp Save(Data.Entity.CheckUp entity);
        List<Data.Entity.CheckUp> Save(List<Data.Entity.CheckUp> entity);

        Data.Entity.CheckUp Update(Data.Entity.CheckUp entity);
        List<Data.Entity.CheckUp> Update(List<Data.Entity.CheckUp> entity);

        void Delete(long id);
        void Delete(Data.Entity.CheckUp entity);
        void Delete(List<long> idList);

        List<Data.Entity.CheckUp> Find();
        Data.Entity.CheckUp Find(long id);
    }
}
