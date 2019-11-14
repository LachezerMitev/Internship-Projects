using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.UserGroup
{
    class UserGroupResultConverter : BaseResultConverter<Data.Entity.UserGroup, UserGroupResult>, IUserGroupResultConverter
    {
        public UserGroupResult Convert(Data.Entity.UserGroup param)
        {
            UserGroupResult result = new UserGroupResult();

            ConverterStandart(param, result);

            ConvertSpecific(param, result);

            return result;
        }

        public override UserGroupResult ConvertSpecific(Data.Entity.UserGroup param, UserGroupResult result)
        {
            result.UserGroupStatusId = param.UserGroupStatus.Id;
            result.UserGroupStatusName = param.UserGroupStatus.Name;

            return result;
        }
    }
}
