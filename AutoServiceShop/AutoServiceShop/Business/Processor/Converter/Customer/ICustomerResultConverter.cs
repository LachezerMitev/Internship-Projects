﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Customer
{
    interface ICustomerResultConverter
    {
        CustomerResult Convert(AutoServiceShop.Data.Entity.Customer param);
    }
}
