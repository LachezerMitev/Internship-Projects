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

        private readonly IUserGroupStatusDao _userGroupStatusDao;

        public UserGroupParamConverter(IUserGroupStatusDao userGroupStatusDao)
        {
            _userGroupStatusDao = userGroupStatusDao;
        }

        public override void ConvertSpecific(UserGroupParam param, Data.Entity.UserGroup entity)
        {
            entity.UserGroupStatus = _userGroupStatusDao.Find(param.UserGroupStatusId);
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
