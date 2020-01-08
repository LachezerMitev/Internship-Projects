using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.UserGroup;
using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;

namespace AutoServiceShop.Business.Processor.Converter.UserGroup
{
    class UserGroupParamConverter : BaseParamConverter<UserGroupParam, Data.Entity.UserGroup>, IUserGroupParamConverter
    {
        private IUserGroupDao _userGroupDao;
        public IUserGroupDao UserGroupDao
        {

            set { _userGroupDao = value; }

            get
            {
                if (_userGroupDao == null)
                {
                    return _userGroupDao;
                }
                else
                {
                    return _userGroupDao;
                }
            }
        }

        private IUserGroupStatusDao _userGroupStatusDao;
        public IUserGroupStatusDao UserGroupStatusDao
        {

            set { _userGroupStatusDao = value; }

            get
            {
                if (_userGroupStatusDao == null)
                {
                    return _userGroupStatusDao;
                }
                else
                {
                    return _userGroupStatusDao;
                }
            }
        }

        

        public override void ConvertSpecific(UserGroupParam param, Data.Entity.UserGroup entity)
        {
            entity.UserGroupStatus = UserGroupStatusDao.Find(param.UserGroupStatusId);
        }

        public override Data.Entity.UserGroup GetResult(UserGroupParam param)
        {
            Data.Entity.UserGroup entity = new Data.Entity.UserGroup
            {
                Id = param.Id,
                Code = param.Code
            };

            return entity;
        }
    }
}
