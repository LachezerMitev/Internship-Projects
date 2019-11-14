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
        public UserUserGroupResult Convert(Data.Entity.UserUserGroup param)
        {
            UserUserGroupResult result = new UserUserGroupResult();

            ConverterStandart(param, result);

            return result;
        }

        public override UserUserGroupResult ConvertSpecific(Data.Entity.UserUserGroup param, UserUserGroupResult result)
        {
            result.UserId = param.User.Id;
            result.Username = param.User.Username;

            return result;
        }
    }
}
