﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.CustomerStatus
{
    interface ICustomerStatusResultConverter
    {
        CustomerStatusResult Convert(AutoServiceShop.Data.Entity.CustomerStatus param);
    }
}
