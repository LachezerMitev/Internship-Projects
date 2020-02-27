using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;
using AutoServiceShop.Business.Processor.UserGroupStatus;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.UserGroupStatusController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationUserGroupStatus]
    public class UserGroupStatusController
        : BaseController<IUserGroupStatusProcessor, IUserGroupStatusParamConverter, IUserGroupStatusResultConverter, UserGroupStatusParam, UserGroupStatusResult, IUserGroupStatusDao, long, Data.Entity.UserGroupStatus>, IUserGroupStatusController
    {
        public UserGroupStatusController(IUserGroupStatusProcessor processor) : base(processor)
        {
        }
    }
}
