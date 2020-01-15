using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Dataaccess.Dao.Model
{
    class ModelDaoFile : BaseDaoFile<Data.Entity.Model, long, ModelStorage>, IModelDao
    {
        protected override long GetPK(Data.Entity.Model entity) => entity.Id;
    }
}
