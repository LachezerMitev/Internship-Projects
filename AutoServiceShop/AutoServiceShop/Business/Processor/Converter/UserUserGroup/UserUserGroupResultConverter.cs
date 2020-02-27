using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.UserUserGroup
{
    class UserUserGroupResultConverter : IUserUserGroupResultConverter
    {
        public UserUserGroupResult Convert(Data.Entity.UserUserGroup param)
        {
<<<<<<< Updated upstream
            UserUserGroupResult result = new UserUserGroupResult()
            {
                Id = param.Id,

                UserId = param.User.Id,
                Username = param.User.Username,
                UserGroupList = param.UserGroupList
            };

            return result;
=======
            if (param.User == null)
                throw new Exception("Some or all items in the entity thаt are crucial were not found");

            result.UserId = param.User.Id;
            result.Username = param.User.Username;
            result.UserGroupName = param.UserGroup.Name;
            result.UserGroupId = param.UserGroup.Id;
>>>>>>> Stashed changes
        }
    }
}
