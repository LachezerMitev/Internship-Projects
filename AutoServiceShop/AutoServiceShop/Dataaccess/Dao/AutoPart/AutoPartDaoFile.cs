using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Dataaccess.Dao.AutoPart
{
    class AutoPartDaoFile : BaseDaoFile<Data.Entity.AutoPart, long, AutoPartStorage>, IAutoPartDao
    {
        protected override long GetPK(Data.Entity.AutoPart entity) => entity.Id;
    }
}
