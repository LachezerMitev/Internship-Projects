using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Dataaccess.Dao.AutoPartStatus
{
    class AutoPartStatusDaoFile : BaseDaoFile<Data.Entity.AutoPartStatus, long, AutoPartStatusStorage>, IAutoPartStatusDao
    {
        protected override long GetPK(Data.Entity.AutoPartStatus entity) => entity.Id;
    }
}
