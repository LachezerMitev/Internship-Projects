using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.UserUserGroup;
using AutoServiceShop.Dataaccess.Dao.User;
using AutoServiceShop.Business.Processor.Converter.Common;

namespace AutoServiceShop.Business.Processor.Converter.UserUserGroup
{
    class UserUserGroupParamConverter : BaseParamConverter<UserUserGroupParam, Data.Entity.UserUserGroup>, IUserUserGroupParamConverter
    {
<<<<<<< Updated upstream
        IUserUserGroupDao UserUserGroupDao = new UserUserGroupDao();
        IUserDao UserDao = new UserDao();
=======
        private IUserDao _userDao;
        public IUserDao UserDao
        {

            set { _userDao = value; }

            get
            {
                if (_userDao == null)
                {
                    return _userDao;
                }
                else
                {
                    return _userDao;
                }
            }
        }
>>>>>>> Stashed changes

        

<<<<<<< Updated upstream
            entity.UserGroupList = param.UserGroupList;
            entity.User = UserDao.Find(param.UserId);
=======
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
