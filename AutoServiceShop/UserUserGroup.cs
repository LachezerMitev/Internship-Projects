using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop
{
    class UserUserGroup : Persistent
    {
        List<UserGroup> UserGroupList { get; set; }
        User User { get; set; }
    }
}
