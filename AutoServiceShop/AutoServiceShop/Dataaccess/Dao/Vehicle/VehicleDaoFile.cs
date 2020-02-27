using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Dataaccess.Dao.Vehicle
{
    class VehicleDaoFile : BaseDaoFile<Data.Entity.Vehicle, long, VehicleStorage>, IVehicleDao
    {
        protected override long GetPK(Data.Entity.Vehicle entity) => entity.Id;
    }
}
