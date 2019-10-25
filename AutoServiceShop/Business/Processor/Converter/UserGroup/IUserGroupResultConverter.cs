using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.UserGroup
{
    interface IUserGroupResultConverter
    {
        UserGroupResult Convert(AutoServiceShop.Data.Entity.UserGroup param);
    }
}
