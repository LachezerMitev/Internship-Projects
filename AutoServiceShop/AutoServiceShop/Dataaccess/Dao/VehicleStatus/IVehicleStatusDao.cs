using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.VehicleStatus
{
    interface IVehicleStatusDao
    {
<<<<<<< Updated upstream
        Data.Entity.VehicleStatus Save(Data.Entity.VehicleStatus entity);
        List<Data.Entity.VehicleStatus> Save(List<Data.Entity.VehicleStatus> entity);

        Data.Entity.VehicleStatus Update(Data.Entity.VehicleStatus entity);
        List<Data.Entity.VehicleStatus> Update(List<Data.Entity.VehicleStatus> entity);

        void Delete(long id);
        void Delete(Data.Entity.VehicleStatus entity);
        void Delete(List<long> idList);

        List<Data.Entity.VehicleStatus> Find();
        Data.Entity.VehicleStatus Find(long id);
=======
>>>>>>> Stashed changes
    }
}
