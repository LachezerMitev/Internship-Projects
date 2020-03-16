using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Business.Processor.User;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.UserController
{
    interface IUserController
        : IBaseController<IUserProcessor, IUserParamConverter, IUserResultConverter, UserParam, UserResult, IUserDao, long, Data.Entity.User>
    {
    }
}
