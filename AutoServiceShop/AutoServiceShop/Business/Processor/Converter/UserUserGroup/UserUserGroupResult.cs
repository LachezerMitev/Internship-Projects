using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.UserUserGroup
{
<<<<<<< Updated upstream
    class UserUserGroupResult : BaseResultNamed
=======
    public class UserUserGroupResult : BaseResult
>>>>>>> Stashed changes
    {
        public long UserId { get; set; }

        public long UserGroupId { get; set; }

        public string UserGroupName { get; set; }

        public string Username { get; set; }
    }
}
