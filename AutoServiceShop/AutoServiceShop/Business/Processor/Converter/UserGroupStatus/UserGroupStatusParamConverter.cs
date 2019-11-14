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

        public Data.Entity.UserGroupStatus Convert(UserGroupStatusParam param, Data.Entity.UserGroupStatus oldentity)
        {
            Data.Entity.UserGroupStatus entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.UserGroupStatus
                {
                    Code = param.Code,
                    Id = param.Id
                };
            }

            ConverterStandart(param, entity);

            return entity;
        }

        public override Data.Entity.UserGroupStatus ConvertSpecific(UserGroupStatusParam param, Data.Entity.UserGroupStatus entity)
        {
            throw new NotImplementedException();
        }
    }
}
