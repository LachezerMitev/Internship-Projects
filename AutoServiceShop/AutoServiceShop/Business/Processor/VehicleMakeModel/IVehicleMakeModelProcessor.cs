using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.VehicleMakeModel;
using AutoServiceShop.Dataaccess.Dao.VehicleMakeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.VehicleMakeModel
{
    public interface IVehicleMakeModelProcessor
        : IBaseProcessor<IVehicleMakeModelParamConverter, IVehicleMakeModelResultConverter, VehicleMakeModelParam, VehicleMakeModelResult, IVehicleMakeModelDao, long, Data.Entity.VehicleMakeModel>
    {
    }
}
