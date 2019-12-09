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
        private IUserDao _userDao;
        public IUserDao UserDao
        {

            set { _userDao = value; }

            get
            {
                if (_userDao == null)
                {
                    _userDao = new UserDao();
                    return _userDao;
                }
                else
                {
                    return _userDao;
                }
            }
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
                entity = new Data.Entity.UserUserGroup
                {
                    Id = param.Id
                };
            }

<<<<<<< Updated upstream
            entity.UserGroupList = param.UserGroupList;
            entity.User = UserDao.Find(param.UserId);
=======
            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.UserUserGroup ConvertSpecific(UserUserGroupParam param, Data.Entity.UserUserGroup entity)
        {
            entity.User = _userDao.Find(param.UserId);
>>>>>>> Stashed changes

            return entity;
        }
    }
}
