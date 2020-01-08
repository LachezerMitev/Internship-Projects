using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.UserGroupStatus;
using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;

namespace AutoServiceShop.Presentation.service.UserGroupStatus
{
    public interface IUserGroupStatusService
        : IBaseService<IUserGroupStatusProcessor, IUserGroupStatusParamConverter, IUserGroupStatusResultConverter, UserGroupStatusParam, UserGroupStatusResult, IUserGroupStatusDao, long, Data.Entity.UserGroupStatus>
    {
    }
}
