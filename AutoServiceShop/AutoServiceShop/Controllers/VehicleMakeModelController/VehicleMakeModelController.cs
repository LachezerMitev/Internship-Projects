using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.Converter.VehicleMakeModel;
using AutoServiceShop.Business.Processor.VehicleMakeModel;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.VehicleMakeModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.VehicleMakeModelController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationVehicleMakeModel]
    public class VehicleMakeModelController
        : BaseController<IVehicleMakeModelProcessor, IVehicleMakeModelParamConverter, IVehicleMakeModelResultConverter, VehicleMakeModelParam, VehicleMakeModelResult, IVehicleMakeModelDao, long, Data.Entity.VehicleMakeModel>, IVehicleMakeModelController
    {
        public VehicleMakeModelController(IVehicleMakeModelProcessor processor) : base(processor)
        {
        }
    }
}
