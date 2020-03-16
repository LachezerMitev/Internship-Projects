using AutoServiceShop.Business.Processor.AutoPartStatus;
using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.AutoPartStatusController
{
    interface IAutoPartStatusController
        : IBaseController<IAutoPartStatusProcessor, IAutoPartStatusParamConverter, IAutoPartStatusResultConverter, AutoPartStatusParam, AutoPartStatusResult, IAutoPartStatusDao, long, Data.Entity.AutoPartStatus>
    {
    }
}
