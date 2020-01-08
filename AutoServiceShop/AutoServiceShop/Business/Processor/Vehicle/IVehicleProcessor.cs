using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.Vehicle;
using AutoServiceShop.Dataaccess.Dao.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Vehicle
{
    public interface IVehicleProcessor
        : IBaseProcessor<IVehicleParamConverter, IVehicleResultConverter, VehicleParam, VehicleResult, IVehicleDao, long, Data.Entity.Vehicle>
    {
    }
}
