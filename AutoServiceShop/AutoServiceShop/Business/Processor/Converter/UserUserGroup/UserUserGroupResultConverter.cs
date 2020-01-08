using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.UserUserGroup
{
    class UserUserGroupResultConverter : BaseResultConverter<Data.Entity.UserUserGroup, UserUserGroupResult>, IUserUserGroupResultConverter
    {
        public override void ConvertSpecific(Data.Entity.UserUserGroup param, UserUserGroupResult result)
        {
            result.UserId = param.User.Id;
            result.Username = param.User.Username;
        }
    }
}
