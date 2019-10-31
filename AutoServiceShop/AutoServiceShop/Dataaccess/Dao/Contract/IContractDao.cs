using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Contract
{
    interface IContractDao
    {
        Data.Entity.Contract Save(Data.Entity.Contract entity);
        List<Data.Entity.Contract> Save(List<Data.Entity.Contract> entity);

        Data.Entity.Contract Update(Data.Entity.Contract entity);
        List<Data.Entity.Contract> Update(List<Data.Entity.Contract> entity);

        void Delete(long id);
        void Delete(Data.Entity.Contract entity);
        void Delete(List<long> idList);

        List<Data.Entity.Contract> Find();
        Data.Entity.Contract Find(long id);
    }
}
