﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.VehicleMakeModel
{
    interface IVehicleMakeModelResultConverter
    {
        VehicleMakeModelResult Convert(AutoServiceShop.Data.Entity.VehicleMakeModel param);
    }
}
