using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.UserGroupStatus
{
    interface IUserGroupStatusParamConverter
    {
        AutoServiceShop.Data.Entity.UserGroupStatus Convert(UserGroupStatusParam param);
    }
}
