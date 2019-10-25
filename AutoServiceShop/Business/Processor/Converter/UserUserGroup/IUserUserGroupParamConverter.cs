using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.UserUserGroup
{
    interface IUserUserGroupParamConverter
    {
        AutoServiceShop.Data.Entity.UserUserGroup Convert(UserUserGroupParam param);
    }
}
