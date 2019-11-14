﻿
using AutoServiceShop.Business.Processor.Converter.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Account
{
    interface IAccountResultConverter : IBaseResultConverter<Data.Entity.Account, AccountResult>
    {
        AccountResult Convert(AutoServiceShop.Data.Entity.Account param);
    }
}
