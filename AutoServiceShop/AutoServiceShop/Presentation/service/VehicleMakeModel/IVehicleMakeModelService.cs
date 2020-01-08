using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.VehicleMakeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.VehicleMakeModel;
using AutoServiceShop.Dataaccess.Dao.VehicleMakeModel;

namespace AutoServiceShop.Presentation.service.VehicleMakeModel
{
    public interface IVehicleMakeModelService
        : IBaseService<IVehicleMakeModelProcessor, IVehicleMakeModelParamConverter, IVehicleMakeModelResultConverter, VehicleMakeModelParam, VehicleMakeModelResult, IVehicleMakeModelDao, long, Data.Entity.VehicleMakeModel>
    {
    }
}
