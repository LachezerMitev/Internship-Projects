﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.UserGroupStatus
{
    interface IUserGroupStatusResultConverter
    {
        UserGroupStatusResult Convert(AutoServiceShop.Data.Entity.UserGroupStatus param);
    }
}
