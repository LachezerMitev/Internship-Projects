﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Vehicle;

namespace AutoServiceShop.Business.Processor.Converter.Vehicle
{
    class VehicleParamConverter : IVehicleParamConverter
    {
        VehicleDao VehicleDao { get; set; }

        public Data.Entity.Vehicle Convert(VehicleParam param)
        {
            throw new NotImplementedException();
        }
    }
}
