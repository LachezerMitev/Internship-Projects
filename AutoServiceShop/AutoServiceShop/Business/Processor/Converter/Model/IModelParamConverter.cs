﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Model
{
    interface IModelParamConverter
    {
        AutoServiceShop.Data.Entity.Model Convert(ModelParam param, Data.Entity.Model oldentity);
    }
}
