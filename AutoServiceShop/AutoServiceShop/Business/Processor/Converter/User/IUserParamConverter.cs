﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.User
{
    interface IUserParamConverter
    {
        AutoServiceShop.Data.Entity.User Convert(UserParam param, Data.Entity.User oldentity);
    }
}
