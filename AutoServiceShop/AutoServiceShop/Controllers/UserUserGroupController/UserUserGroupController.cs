using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.Converter.UserUserGroup;
using AutoServiceShop.Business.Processor.UserUserGroup;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.UserUserGroup;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.UserUserGroupController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationUserUserGroup]
    public class UserUserGroupController
        : BaseController<IUserUserGroupProcessor, IUserUserGroupParamConverter, IUserUserGroupResultConverter, UserUserGroupParam, UserUserGroupResult, IUserUserGroupDao, long, Data.Entity.UserUserGroup>, IUserUserGroupController
    {
        public UserUserGroupController(IUserUserGroupProcessor processor) : base(processor)
        {
        }
    }
}
