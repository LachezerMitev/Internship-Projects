using AutoServiceShop.Business.Processor.Converter.VehicleStatus;
using AutoServiceShop.Business.Processor.VehicleStatus;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.VehicleStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.VehicleStatusController
{
    interface IVehicleStatusController
        : IBaseController<IVehicleStatusProcessor, IVehicleStatusParamConverter, IVehicleStatusResultConverter, VehicleStatusParam, VehicleStatusResult, IVehicleStatusDao, long, Data.Entity.VehicleStatus>
    {
    }
}
