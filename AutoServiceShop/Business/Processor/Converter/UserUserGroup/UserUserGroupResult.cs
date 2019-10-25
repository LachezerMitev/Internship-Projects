using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.UserUserGroup
{
    class UserUserGroupResult : BaseResultNamed
    {
        public List<Data.Entity.UserGroup> UserGroupList { get; set; }
        public Data.Entity.User User { get; set; }
    }
}
