using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.Converter.UserGroup;
using AutoServiceShop.Business.Processor.UserGroup;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.UserGroup;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.UserGroupController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationUserGroup]
    public class UserGroupController
        : BaseController<IUserGroupProcessor, IUserGroupParamConverter, IUserGroupResultConverter, UserGroupParam, UserGroupResult, IUserGroupDao, long, Data.Entity.UserGroup>, IUserGroupController
    {
        public UserGroupController(IUserGroupProcessor processor) : base(processor)
        {
        }
    }
}
