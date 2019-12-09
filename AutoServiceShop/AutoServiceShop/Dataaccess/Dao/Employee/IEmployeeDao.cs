using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Employee
{
    interface IEmployeeDao
    {
        Data.Entity.Employee Save(Data.Entity.Employee entity);
        List<Data.Entity.Employee> Save(List<Data.Entity.Employee> entity);

        Data.Entity.Employee Update(Data.Entity.Employee entity);
        List<Data.Entity.Employee> Update(List<Data.Entity.Employee> entity);

        void Delete(long id);
        void Delete(Data.Entity.Employee entity);
        void Delete(List<long> idList);

        List<Data.Entity.Employee> Find();
        Data.Entity.Employee Find(long id);
        List<Data.Entity.Employee> FindByField(string field, string value);
    }
}
