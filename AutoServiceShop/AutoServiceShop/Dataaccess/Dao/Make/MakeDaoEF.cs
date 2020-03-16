using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Make
{
    class MakeDaoEF : BaseDaoEF<Data.Entity.Make, long>, IMakeDao
    {
        public MakeDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
