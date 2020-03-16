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
<<<<<<< Updated upstream
        public List<UserGroup> UserGroupList { get; set; }
        public User User { get; set; }
=======
        [ForeignKey("UserGroup")]
        public long UserGroupId { get; set; }

        public virtual UserGroup UserGroup { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }

        public virtual User User { get; set; }
>>>>>>> Stashed changes
    }
}
