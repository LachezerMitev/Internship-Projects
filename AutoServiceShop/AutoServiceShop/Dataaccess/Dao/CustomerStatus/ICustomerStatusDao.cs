using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.CustomerStatus
{
    interface ICustomerStatusDao
    {
        Data.Entity.CustomerStatus Save(Data.Entity.CustomerStatus entity);
        List<Data.Entity.CustomerStatus> Save(List<Data.Entity.CustomerStatus> entity);

        Data.Entity.CustomerStatus Update(Data.Entity.CustomerStatus entity);
        List<Data.Entity.CustomerStatus> Update(List<Data.Entity.CustomerStatus> entity);

        void Delete(long id);
        void Delete(Data.Entity.CustomerStatus entity);
        void Delete(List<long> idList);

        List<Data.Entity.CustomerStatus> Find();
        Data.Entity.CustomerStatus Find(long id);
    }
}
