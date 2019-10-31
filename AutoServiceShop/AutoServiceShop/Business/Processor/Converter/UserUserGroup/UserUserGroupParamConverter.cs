using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.UserUserGroup;
using AutoServiceShop.Dataaccess.Dao.User;

namespace AutoServiceShop.Business.Processor.Converter.UserUserGroup
{
    class UserUserGroupParamConverter : IUserUserGroupParamConverter
    {
        IUserUserGroupDao UserUserGroupDao = new UserUserGroupDao();
        IUserDao UserDao = new UserDao();

        public Data.Entity.UserUserGroup Convert(UserUserGroupParam param, Data.Entity.UserUserGroup oldentity)
        {
            Data.Entity.UserUserGroup entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.UserUserGroup
                {
                    Id = param.Id
                };
            }

            entity.UserGroupList = param.UserGroupList;
            entity.User = UserDao.Find(param.UserId);

            return entity;
        }
    }
}
