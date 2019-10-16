using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.VehicleStatus;

namespace AutoServiceShop.Business.Processor.Converter.VehicleStatus
{
    class VehicleStatusParamConverter : IVehicleStatusParamConverter
    {
        VehicleStatusDao VehicleStatusDao { get; set; }

        public Data.Entity.VehicleStatus Convert(VehicleStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
