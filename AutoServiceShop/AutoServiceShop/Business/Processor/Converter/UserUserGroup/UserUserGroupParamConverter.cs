using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.UserUserGroup;
using AutoServiceShop.Dataaccess.Dao.User;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Dataaccess.Dao.UserGroup;

namespace AutoServiceShop.Business.Processor.Converter.UserUserGroup
{
    class UserUserGroupParamConverter : BaseParamConverter<UserUserGroupParam, Data.Entity.UserUserGroup>, IUserUserGroupParamConverter
    {
<<<<<<< Updated upstream
        IUserUserGroupDao UserUserGroupDao = new UserUserGroupDao();
        IUserDao UserDao = new UserDao();
=======
        private readonly IUserDao _userDao;
        private readonly IUserGroupDao _userGroupDao;
>>>>>>> Stashed changes

        public UserUserGroupParamConverter(IUserDao userDao, IUserGroupDao userGroupDao)
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
            _userGroupDao = userGroupDao;
        }

        public override void ConvertSpecific(UserUserGroupParam param, Data.Entity.UserUserGroup entity)
        {
            entity.User = _userDao.Find(param.UserId);
            entity.UserGroup = _userGroupDao.Find(param.UserGroupId);
        }

        public override Data.Entity.UserUserGroup GetResult(UserUserGroupParam param)
        {
            Data.Entity.UserUserGroup entity = new Data.Entity.UserUserGroup
            {
                Id = param.Id,
                Active = param.Active
            };
>>>>>>> Stashed changes

            return entity;
        }
    }
}
