using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;

namespace AutoServiceShop.Business.Processor.Converter.UserGroupStatus
{
    class UserGroupStatusParamConverter : BaseParamConverter<UserGroupStatusParam, Data.Entity.UserGroupStatus>, IUserGroupStatusParamConverter
    {
        IUserGroupStatusDao UserGroupStatusDao = new UserGroupStatusDao();

        public override void ConvertSpecific(UserGroupStatusParam param, Data.Entity.UserGroupStatus entity) { }

        public override Data.Entity.UserGroupStatus GetResult(UserGroupStatusParam param)
        {
            Data.Entity.UserGroupStatus entity = new Data.Entity.UserGroupStatus
            {
                Id = param.Id,
                Code = param.Code
            };

            return entity;
        }
    }
}
