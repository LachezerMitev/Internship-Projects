using AutoServiceShop.Business.Processor.Converter.UserGroup;
using AutoServiceShop.Business.Processor.UserGroup;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.UserGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.UserGroupController
{
    interface IUserGroupController
        : IBaseController<IUserGroupProcessor, IUserGroupParamConverter, IUserGroupResultConverter, UserGroupParam, UserGroupResult, IUserGroupDao, long, Data.Entity.UserGroup>
    {
    }
}
