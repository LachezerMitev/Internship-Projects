using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class UserUserGroup : Persistent
    {
        public List<UserGroup> UserGroupList { get; set; }
        public User User { get; set; }
    }
}
