using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.ContractType
{
    class ContractTypeDaoEF : BaseDaoEF<Data.Entity.ContractType, long>, IContractTypeDao
    {
        public ContractTypeDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
