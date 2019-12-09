using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Customer
{
    interface ICustomerDao
    {
        Data.Entity.Customer Save(Data.Entity.Customer entity);
        List<Data.Entity.Customer> Save(List<Data.Entity.Customer> entity);

        Data.Entity.Customer Update(Data.Entity.Customer entity);
        List<Data.Entity.Customer> Update(List<Data.Entity.Customer> entity);

        void Delete(long id);
        void Delete(Data.Entity.Customer entity);
        void Delete(List<long> idList);

        List<Data.Entity.Customer> Find();
        Data.Entity.Customer Find(long id);
        List<Data.Entity.Customer> FindByField(string field, string value);
    }
}
