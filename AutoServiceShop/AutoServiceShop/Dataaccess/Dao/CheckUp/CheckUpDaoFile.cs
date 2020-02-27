using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Dataaccess.Dao.CheckUp
{
    class CheckUpDaoFile : BaseDaoFile<Data.Entity.CheckUp, long, CheckUpStorage>, ICheckUpDao
    {
        protected override long GetPK(Data.Entity.CheckUp entity) => entity.Id;
    }
}
