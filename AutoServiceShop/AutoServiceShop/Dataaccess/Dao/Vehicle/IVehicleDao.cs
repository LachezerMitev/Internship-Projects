using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Vehicle
{
    interface IVehicleDao
    {
        Data.Entity.Vehicle Save(Data.Entity.Vehicle entity);
        List<Data.Entity.Vehicle> Save(List<Data.Entity.Vehicle> entity);

        Data.Entity.Vehicle Update(Data.Entity.Vehicle entity);
        List<Data.Entity.Vehicle> Update(List<Data.Entity.Vehicle> entity);

        void Delete(long id);
        void Delete(Data.Entity.Vehicle entity);
        void Delete(List<long> idList);

        List<Data.Entity.Vehicle> Find();
        Data.Entity.Vehicle Find(long id);
    }
}
