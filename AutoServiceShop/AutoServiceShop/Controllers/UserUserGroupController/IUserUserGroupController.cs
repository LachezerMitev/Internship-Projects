using AutoServiceShop.Business.Processor.Converter.UserUserGroup;
using AutoServiceShop.Business.Processor.UserUserGroup;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.UserUserGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.UserUserGroupController
{
    interface IUserUserGroupController
        : IBaseController<IUserUserGroupProcessor, IUserUserGroupParamConverter, IUserUserGroupResultConverter, UserUserGroupParam, UserUserGroupResult, IUserUserGroupDao, long, Data.Entity.UserUserGroup>
    {
    }
}
