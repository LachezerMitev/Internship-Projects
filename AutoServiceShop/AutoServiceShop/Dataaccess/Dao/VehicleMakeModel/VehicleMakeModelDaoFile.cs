using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Dataaccess.Dao.VehicleMakeModel
{
    class VehicleMakeModelDaoFile : BaseDaoFile<Data.Entity.VehicleMakeModel, long, VehicleMakeModelStorage>, IVehicleMakeModelDao
    {
        protected override long GetPK(Data.Entity.VehicleMakeModel entity) => entity.Id;
    }
}
