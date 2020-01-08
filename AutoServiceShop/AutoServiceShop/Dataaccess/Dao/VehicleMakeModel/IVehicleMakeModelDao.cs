using AutoServiceShop.Dataaccess.Dao.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.VehicleMakeModel
{
    public interface IVehicleMakeModelDao : IBaseDao<Data.Entity.VehicleMakeModel, long>
    {
<<<<<<< Updated upstream
        Data.Entity.VehicleMakeModel Save(Data.Entity.VehicleMakeModel entity);
        List<Data.Entity.VehicleMakeModel> Save(List<Data.Entity.VehicleMakeModel> entity);

        Data.Entity.VehicleMakeModel Update(Data.Entity.VehicleMakeModel entity);
        List<Data.Entity.VehicleMakeModel> Update(List<Data.Entity.VehicleMakeModel> entity);

        void Delete(long id);
        void Delete(Data.Entity.VehicleMakeModel entity);
        void Delete(List<long> idList);

        List<Data.Entity.VehicleMakeModel> Find();
        Data.Entity.VehicleMakeModel Find(long id);
=======
>>>>>>> Stashed changes
    }
}
