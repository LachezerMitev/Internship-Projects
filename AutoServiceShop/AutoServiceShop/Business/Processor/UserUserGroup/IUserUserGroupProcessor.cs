using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.UserUserGroup;
using AutoServiceShop.Dataaccess.Dao.UserUserGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.UserUserGroup
{
    public interface IUserUserGroupProcessor
        : IBaseProcessor<IUserUserGroupParamConverter, IUserUserGroupResultConverter, UserUserGroupParam, UserUserGroupResult, IUserUserGroupDao, long, Data.Entity.UserUserGroup>
    {
    }
}
