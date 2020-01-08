using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Dataaccess.Dao.VehicleStatus
{
    class VehicleStatusDaoFile : BaseDaoFile<Data.Entity.VehicleStatus, long, VehicleStatusStorage>, IVehicleStatusDao
    {
        
    }
}
