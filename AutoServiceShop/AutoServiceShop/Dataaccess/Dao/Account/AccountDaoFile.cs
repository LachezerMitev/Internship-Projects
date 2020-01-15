using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;

namespace AutoServiceShop.Dataaccess.Dao.Account
{
    class AccountDaoFile : BaseDaoFile<Data.Entity.Account, long, AccountStorage>, IAccountDao
    {
        protected override long GetPK(Data.Entity.Account entity) => entity.Id;
    }
}
