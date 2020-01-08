using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.UserGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.UserGroup;
using AutoServiceShop.Dataaccess.Dao.UserGroup;

namespace AutoServiceShop.Presentation.service.UserGroup
{
    public interface IUserGroupService
        : IBaseService<IUserGroupProcessor, IUserGroupParamConverter, IUserGroupResultConverter, UserGroupParam, UserGroupResult, IUserGroupDao, long, Data.Entity.UserGroup>
    {
    }
}
