using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.UserGroup;

namespace AutoServiceShop.Business.Processor.Converter.UserGroup
{
    class UserGroupParamConverter : IUserGroupParamConverter
    {
        IUserGroupDao UserGroupDao { get; set; }

        public Data.Entity.UserGroup Convert(UserGroupParam param)
        {
            Data.Entity.UserGroup result = new Data.Entity.UserGroup()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,

                UserGroupStatus = param.UserGroupStatus
            };

            return result;
        }

        public Data.Entity.UserGroup Convert(UserGroupParam param, Data.Entity.UserGroup oldentity)
        {
            Data.Entity.UserGroup entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.UserGroup();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;

            entity.UserGroupStatus = param.UserGroupStatus;

            return entity;
        }
    }
}
