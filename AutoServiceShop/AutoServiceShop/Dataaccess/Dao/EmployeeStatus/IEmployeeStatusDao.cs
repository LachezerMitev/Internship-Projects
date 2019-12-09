using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.EmployeeStatus
{
    interface IEmployeeStatusDao
    {
        Data.Entity.EmployeeStatus Save(Data.Entity.EmployeeStatus entity);
        List<Data.Entity.EmployeeStatus> Save(List<Data.Entity.EmployeeStatus> entity);

        Data.Entity.EmployeeStatus Update(Data.Entity.EmployeeStatus entity);
        List<Data.Entity.EmployeeStatus> Update(List<Data.Entity.EmployeeStatus> entity);

        void Delete(long id);
        void Delete(Data.Entity.EmployeeStatus entity);
        void Delete(List<long> idList);

        List<Data.Entity.EmployeeStatus> Find();
        Data.Entity.EmployeeStatus Find(long id);
        List<Data.Entity.EmployeeStatus> FindByField(string field, string value);
    }
}
