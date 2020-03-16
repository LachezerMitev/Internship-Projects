using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.UserGroup;
using AutoServiceShop.Dataaccess.Dao.UserGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.UserGroup
{
    public interface IUserGroupProcessor
        : IBaseProcessor<IUserGroupParamConverter, IUserGroupResultConverter, UserGroupParam, UserGroupResult, IUserGroupDao, long, Data.Entity.UserGroup>
    {
    }
}
