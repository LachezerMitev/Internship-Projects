using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.VehicleStatus;
using AutoServiceShop.Dataaccess.Dao.VehicleStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.VehicleStatus
{
    public interface IVehicleStatusProcessor
        : IBaseProcessor<IVehicleStatusParamConverter, IVehicleStatusResultConverter, VehicleStatusParam, VehicleStatusResult, IVehicleStatusDao, long, Data.Entity.VehicleStatus>
    {
    }
}
