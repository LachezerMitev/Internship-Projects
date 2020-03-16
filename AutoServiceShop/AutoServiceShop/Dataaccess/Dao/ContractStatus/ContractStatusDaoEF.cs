using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.ContractStatus
{
    class ContractStatusDaoEF : BaseDaoEF<Data.Entity.ContractStatus, long>, IContractStatusDao
    {
        public ContractStatusDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
