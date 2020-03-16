using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;
using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.UserGroupStatus
{
    public interface IUserGroupStatusProcessor
        : IBaseProcessor<IUserGroupStatusParamConverter, IUserGroupStatusResultConverter, UserGroupStatusParam, UserGroupStatusResult, IUserGroupStatusDao, long, Data.Entity.UserGroupStatus>
    {
    }
}
