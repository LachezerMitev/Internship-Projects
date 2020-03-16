using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;
using AutoServiceShop.Business.Processor.UserGroupStatus;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.UserGroupStatusController
{
    interface IUserGroupStatusController
        : IBaseController<IUserGroupStatusProcessor, IUserGroupStatusParamConverter, IUserGroupStatusResultConverter, UserGroupStatusParam, UserGroupStatusResult, IUserGroupStatusDao, long, Data.Entity.UserGroupStatus>
    {
    }
}
