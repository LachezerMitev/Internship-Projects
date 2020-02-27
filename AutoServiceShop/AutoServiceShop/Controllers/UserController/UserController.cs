using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Business.Processor.User;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.UserController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationUser]
    public class UserController
        : BaseController<IUserProcessor, IUserParamConverter, IUserResultConverter, UserParam, UserResult, IUserDao, long, Data.Entity.User>, IUserController
    {
        public UserController(IUserProcessor processor) : base(processor)
        {
        }
    }
}
