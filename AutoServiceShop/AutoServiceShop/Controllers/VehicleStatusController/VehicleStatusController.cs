using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.Converter.VehicleStatus;
using AutoServiceShop.Business.Processor.VehicleStatus;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.VehicleStatus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.VehicleStatusController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationVehicleStatus]
    public class VehicleStatusController
        : BaseController<IVehicleStatusProcessor, IVehicleStatusParamConverter, IVehicleStatusResultConverter, VehicleStatusParam, VehicleStatusResult, IVehicleStatusDao, long, Data.Entity.VehicleStatus>, IVehicleStatusController
    {
        public VehicleStatusController(IVehicleStatusProcessor processor) : base(processor)
        {
        }
    }
}
