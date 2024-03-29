﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;

namespace AutoServiceShop.Business.Processor.Converter.UserGroupStatus
{
    class UserGroupStatusParamConverter : IUserGroupStatusParamConverter
    {
        IUserGroupStatusDao UserGroupStatusDao = new UserGroupStatusDao();

        public Data.Entity.UserGroupStatus Convert(UserGroupStatusParam param, Data.Entity.UserGroupStatus oldentity)
        {
            Data.Entity.UserGroupStatus entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.UserGroupStatus
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }


            return entity;
        }
    }
}
