﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.AutoPartStatus
{
    interface IAutoPartStatusResultConverter
    {
        AutoPartStatusResult Convert(AutoServiceShop.Data.Entity.AutoPartStatus param);
    }
}
