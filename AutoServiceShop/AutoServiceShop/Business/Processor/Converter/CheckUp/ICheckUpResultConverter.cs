﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.CheckUp
{
    interface ICheckUpResultConverter
    {
        CheckUpResult Convert(AutoServiceShop.Data.Entity.CheckUp param);
    }
}
