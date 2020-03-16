using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.CheckUp
{
    class CheckUpDaoEF : BaseDaoEF<Data.Entity.CheckUp, long>, ICheckUpDao
    {
        public CheckUpDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
