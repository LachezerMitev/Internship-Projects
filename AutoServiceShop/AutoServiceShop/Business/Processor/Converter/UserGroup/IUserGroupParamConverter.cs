using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.UserGroup
{
    interface IUserGroupParamConverter
    {
        AutoServiceShop.Data.Entity.UserGroup Convert(UserGroupParam param, Data.Entity.UserGroup oldentity);
    }
}
