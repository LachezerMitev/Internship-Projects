using AutoServiceShop.Dataaccess.Dao.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.VehicleStatus
{
    class VehicleStatusDaoEF : BaseDaoEF<Data.Entity.VehicleStatus, long>, IVehicleStatusDao
    {
    }
}
