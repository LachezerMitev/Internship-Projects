﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Customer
{
    interface ICustomerParamConverter
    {
        AutoServiceShop.Data.Entity.Customer Convert(CustomerParam param, Data.Entity.Customer oldentity);
    }
}