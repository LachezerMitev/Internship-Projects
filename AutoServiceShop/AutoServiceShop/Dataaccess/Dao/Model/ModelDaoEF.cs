using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Model
{
    class ModelDaoEF : BaseDaoEF<Data.Entity.Model, long>, IModelDao
    {
        public ModelDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
