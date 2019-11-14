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
        IUserGroupDao UserGroupDao = new UserGroupDao();
        IUserGroupStatusDao UserGroupStatusDao = new UserGroupStatusDao();

        public Data.Entity.UserGroup Convert(UserGroupParam param, Data.Entity.UserGroup oldentity)
        {
            Data.Entity.UserGroup entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.UserGroup
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.UserGroup ConvertSpecific(UserGroupParam param, Data.Entity.UserGroup entity)
        {
            entity.UserGroupStatus = UserGroupStatusDao.Find(param.UserGroupStatusId);

            return entity;
        }
    }
}
