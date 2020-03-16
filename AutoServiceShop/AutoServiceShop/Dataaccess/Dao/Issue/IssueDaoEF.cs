using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Issue
{
    class IssueDaoEF : BaseDaoEF<Data.Entity.Issue, long>, IIssueDao
    {
        public IssueDaoEF(AutoServiceShopContext context) : base(context)
        {
        }
    }
}
