using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Dataaccess.Dao.Make
{
    class MakeDaoFile : BaseDaoFile<Data.Entity.Make, long, MakeStorage>, IMakeDao
    {
        protected override long GetPK(Data.Entity.Make entity) => entity.Id;
    }
}
