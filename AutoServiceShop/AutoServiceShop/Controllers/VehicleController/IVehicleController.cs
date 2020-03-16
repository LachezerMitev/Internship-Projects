using AutoServiceShop.Business.Processor.Converter.Vehicle;
using AutoServiceShop.Business.Processor.Vehicle;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.VehicleController
{
    interface IVehicleController
        : IBaseController<IVehicleProcessor, IVehicleParamConverter, IVehicleResultConverter, VehicleParam, VehicleResult, IVehicleDao, long, Data.Entity.Vehicle>
    {
    }
}
