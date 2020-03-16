using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.UserUserGroup
{
<<<<<<< Updated upstream
    class UserUserGroupResult : BaseResultNamed
    {
        public List<Data.Entity.UserGroup> UserGroupList { get; set; }

        public long UserId { get; set; }
        public string Username { get; set; }
=======
    public class UserUserGroupResult : BaseResult
    {
        public long UserId { get; set; }

        public string Username { get; set; }
        public long UserGroupId { get; set; }
        public string UserGroupName { get; set; }
>>>>>>> Stashed changes
    }
}
