using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    public class UserUserGroup : Persistent
    {
        [ForeignKey("UserGroup")]
        public long UserGroupId { get; set; }

        public UserGroup UserGroup { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }

        public User User { get; set; }
    }
}
