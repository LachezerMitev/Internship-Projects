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
<<<<<<< Updated upstream
        IUserUserGroupDao UserUserGroupDao = new UserUserGroupDao();
        IUserDao UserDao = new UserDao();
=======
        private readonly IUserDao _userDao;
>>>>>>> Stashed changes

        public Data.Entity.UserUserGroup Convert(UserUserGroupParam param, Data.Entity.UserUserGroup oldentity)
        {
<<<<<<< Updated upstream
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
=======
            _userDao = userDao;
        }

        public override void ConvertSpecific(UserUserGroupParam param, Data.Entity.UserUserGroup entity)
        {
            entity.User = _userDao.Find(param.UserId);
        }

        public override Data.Entity.UserUserGroup GetResult(UserUserGroupParam param)
        {
            Data.Entity.UserUserGroup entity = new Data.Entity.UserUserGroup
            {
                Id = param.Id
            };
>>>>>>> Stashed changes

            return entity;
        }
    }
}
