using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.CheckUpStatus
{
    public class CheckUpStatusDaoEF : BaseDaoEF<Data.Entity.CheckUpStatus, long>, ICheckUpStatusDao
    {
        public CheckUpStatusDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
