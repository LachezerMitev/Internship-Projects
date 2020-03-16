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

<<<<<<< Updated upstream
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

=======
        public override Data.Entity.UserGroupStatus GetResult(UserGroupStatusParam param)
        {
            Data.Entity.UserGroupStatus entity = new Data.Entity.UserGroupStatus
            {
                Id = param.Id,
                Code = param.Code,
                Active = param.Active
            };
>>>>>>> Stashed changes

            return entity;
        }
    }
}
