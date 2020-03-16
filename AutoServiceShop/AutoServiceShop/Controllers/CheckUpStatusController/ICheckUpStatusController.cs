using AutoServiceShop.Business.Processor.CheckUpStatus;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.CheckUpStatusController
{
    interface ICheckUpStatusController
        : IBaseController<ICheckUpStatusProcessor, ICheckUpStatusParamConverter, ICheckUpStatusResultConverter, CheckUpStatusParam, CheckUpStatusResult, ICheckUpStatusDao, long, Data.Entity.CheckUpStatus>
    {
    }
}
