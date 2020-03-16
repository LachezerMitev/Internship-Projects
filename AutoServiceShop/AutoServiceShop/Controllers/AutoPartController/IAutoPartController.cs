using AutoServiceShop.Business.Processor.AutoPart;
using AutoServiceShop.Business.Processor.Converter.AutoPart;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.AutoPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.AutoPartController
{
    interface IAutoPartController
        : IBaseController<IAutoPartProcessor, IAutoPartParamConverter, IAutoPartResultConvert, AutoPartParam, AutoPartResult, IAutoPartDao, long, Data.Entity.AutoPart>
    {
    }
}
