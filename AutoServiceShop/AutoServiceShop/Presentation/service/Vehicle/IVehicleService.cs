using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.Vehicle;
using AutoServiceShop.Dataaccess.Dao.Vehicle;

namespace AutoServiceShop.Presentation.service.Vehicle
{
    public interface IVehicleService
        : IBaseService<IVehicleProcessor, IVehicleParamConverter, IVehicleResultConverter, VehicleParam, VehicleResult, IVehicleDao, long, Data.Entity.Vehicle>
    {
    }
}
