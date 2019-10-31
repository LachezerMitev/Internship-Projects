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
            UserUserGroupResult result = new UserUserGroupResult()
            {
                Id = param.Id,

                UserId = param.User.Id,
                Username = param.User.Username,
                UserGroupList = param.UserGroupList
            };

            return result;
        }
    }
}
