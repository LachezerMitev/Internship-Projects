using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.VehicleStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.VehicleStatus;
using AutoServiceShop.Dataaccess.Dao.VehicleStatus;

namespace AutoServiceShop.Presentation.service.VehicleStatus
{
    public interface IVehicleStatusService
        : IBaseService<IVehicleStatusProcessor, IVehicleStatusParamConverter, IVehicleStatusResultConverter, VehicleStatusParam, VehicleStatusResult, IVehicleStatusDao, long, Data.Entity.VehicleStatus>
    {
    }
}
