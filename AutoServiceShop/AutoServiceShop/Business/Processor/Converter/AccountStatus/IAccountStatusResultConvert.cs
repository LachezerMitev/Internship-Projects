﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.AccountStatus
{
    interface IAccountStatusResultConvert
    {
        AccountStatusResult Convert(AutoServiceShop.Data.Entity.AccountStatus param);
    }
}
