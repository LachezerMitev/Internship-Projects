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
        public override void ConvertSpecific(Data.Entity.UserGroup param, UserGroupResult result)
        {
<<<<<<< Updated upstream
            UserGroupResult result = new UserGroupResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,

                UserGroupStatusId = param.UserGroupStatus.Id,
                UserGroupStatusName = param.UserGroupStatus.Name
            };

            return result;
=======
            if (param.UserGroupStatus == null)
                throw new Exception("Some or all items in the entity taht are crucial were not found");

            result.UserGroupStatusId = param.UserGroupStatus.Id;
            result.UserGroupStatusName = param.UserGroupStatus.Name;
>>>>>>> Stashed changes
        }
    }
}
