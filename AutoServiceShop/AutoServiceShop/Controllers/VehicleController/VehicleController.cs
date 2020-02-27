using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.Converter.Vehicle;
using AutoServiceShop.Business.Processor.Vehicle;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.Vehicle;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.VehicleController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationVehicle]
    public class VehicleController
        : BaseController<IVehicleProcessor, IVehicleParamConverter, IVehicleResultConverter, VehicleParam, VehicleResult, IVehicleDao, long, Data.Entity.Vehicle>, IVehicleController
    {
        public VehicleController(IVehicleProcessor processor) : base(processor)
        {
        }
    }
}
