using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    public class UserGroup : NamedPersistent
    {

        [ForeignKey("UserGroupStatus")]
        public long UserGroupStatusId { get; set; }

        public UserGroupStatus UserGroupStatus { get; set; }
    }
}
