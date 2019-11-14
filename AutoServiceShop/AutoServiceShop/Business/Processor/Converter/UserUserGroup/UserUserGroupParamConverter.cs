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
        IUserUserGroupDao UserUserGroupDao = new UserUserGroupDao();
        IUserDao UserDao = new UserDao();

        public Data.Entity.UserUserGroup Convert(UserUserGroupParam param, Data.Entity.UserUserGroup oldentity)
        {
            Data.Entity.UserUserGroup entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.UserUserGroup
                {
                    Id = param.Id
                };
            }

            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.UserUserGroup ConvertSpecific(UserUserGroupParam param, Data.Entity.UserUserGroup entity)
        {
            entity.User = UserDao.Find(param.UserId);

            return entity;
        }
    }
}
