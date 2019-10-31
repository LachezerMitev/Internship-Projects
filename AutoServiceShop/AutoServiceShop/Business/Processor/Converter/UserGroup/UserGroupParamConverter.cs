using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.UserGroup;
using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;

namespace AutoServiceShop.Business.Processor.Converter.UserGroup
{
    class UserGroupParamConverter : IUserGroupParamConverter
    {
        IUserGroupDao UserGroupDao = new UserGroupDao();
        IUserGroupStatusDao UserGroupStatusDao = new UserGroupStatusDao();

        public Data.Entity.UserGroup Convert(UserGroupParam param, Data.Entity.UserGroup oldentity)
        {
            Data.Entity.UserGroup entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.UserGroup
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            entity.UserGroupStatus = UserGroupStatusDao.Find(param.UserGroupStatusId);

            return entity;
        }
    }
}
