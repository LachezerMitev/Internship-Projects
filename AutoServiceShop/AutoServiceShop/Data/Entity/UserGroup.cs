using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class UserGroup : NamedPersistent
    {
<<<<<<< Updated upstream
        public UserGroupStatus UserGroupStatus { get; set; }
=======

        [ForeignKey("UserGroupStatus")]
        public long UserGroupStatusId { get; set; }

        public virtual UserGroupStatus UserGroupStatus { get; set; }
>>>>>>> Stashed changes
    }
}
