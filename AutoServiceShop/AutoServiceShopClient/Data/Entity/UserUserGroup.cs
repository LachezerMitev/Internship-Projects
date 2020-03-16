using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShopClient.Data.Entity
{
    public class UserUserGroup : Persistent
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public long UserGroupId { get; set; }
        public string UserGroupName { get; set; }
    }
}
