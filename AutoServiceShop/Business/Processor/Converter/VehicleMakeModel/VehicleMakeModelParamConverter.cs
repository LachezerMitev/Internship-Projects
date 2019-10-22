using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.VehicleMakeModel;

namespace AutoServiceShop.Business.Processor.Converter.VehicleMakeModel
{
    class VehicleMakeModelParamConverter : IVehicleMakeModelParamConverter
    {
        IVehicleMakeModelDao VehicleMakeModelDao { get; set; }

        public Data.Entity.VehicleMakeModel Convert(VehicleMakeModelParam param)
        {
            throw new NotImplementedException();
        }
    }
}
