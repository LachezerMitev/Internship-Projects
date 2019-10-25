using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.UserUserGroup;

namespace AutoServiceShop.Business.Processor.Converter.UserUserGroup
{
    class UserUserGroupParamConverter : IUserUserGroupParamConverter
    {
        IUserUserGroupDao UserUserGroupDao { get; set; }

        public Data.Entity.UserUserGroup Convert(UserUserGroupParam param)
        {
            Data.Entity.UserUserGroup result = new Data.Entity.UserUserGroup()
            {
                Id = param.Id,

                User = param.User,
                UserGroupList = param.UserGroupList
            };

            return result;
        }

        public Data.Entity.UserUserGroup Convert(UserUserGroupParam param, Data.Entity.UserUserGroup oldentity)
        {
            Data.Entity.UserUserGroup entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.UserUserGroup();
            }

            entity.Id = param.Id;

            entity.UserGroupList = param.UserGroupList;
            entity.User = param.User;

            return entity;
        }
    }
}
