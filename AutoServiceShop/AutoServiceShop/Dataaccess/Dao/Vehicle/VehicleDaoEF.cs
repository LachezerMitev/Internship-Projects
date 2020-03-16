using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Vehicle
{
    class VehicleDaoEF : BaseDaoEF<Data.Entity.Vehicle, long>, IVehicleDao
    {
        public VehicleDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
