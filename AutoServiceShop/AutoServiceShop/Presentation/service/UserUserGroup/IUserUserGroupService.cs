using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.UserUserGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.UserUserGroup;
using AutoServiceShop.Dataaccess.Dao.UserUserGroup;

namespace AutoServiceShop.Presentation.service.UserUserGroup
{
    public interface IUserUserGroupService
        : IBaseService<IUserUserGroupProcessor, IUserUserGroupParamConverter, IUserUserGroupResultConverter, UserUserGroupParam, UserUserGroupResult, IUserUserGroupDao, long, Data.Entity.UserUserGroup>
    {
    }
}
