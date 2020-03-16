using AutoServiceShop.Business.Processor.Converter.VehicleMakeModel;
using AutoServiceShop.Business.Processor.VehicleMakeModel;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.VehicleMakeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.VehicleMakeModelController
{
    interface IVehicleMakeModelController
        : IBaseController<IVehicleMakeModelProcessor, IVehicleMakeModelParamConverter, IVehicleMakeModelResultConverter, VehicleMakeModelParam, VehicleMakeModelResult, IVehicleMakeModelDao, long, Data.Entity.VehicleMakeModel>
    {
    }
}
