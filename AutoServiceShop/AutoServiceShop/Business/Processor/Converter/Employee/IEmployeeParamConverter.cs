﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Employee
{
    interface IEmployeeParamConverter
    {
        AutoServiceShop.Data.Entity.Employee Convert(EmployeeParam param, Data.Entity.Employee oldentity);
    }
}
