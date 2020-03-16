using AutoServiceShop.Business.Processor.Converter.Make;
using AutoServiceShop.Business.Processor.Make;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.Make;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.MakeController
{
    interface IMakeController
        : IBaseController<IMakeProcessor, IMakeParamConverter, IMakeResultConverter, MakeParam, MakeResult, IMakeDao, long, Data.Entity.Make>
    {
    }
}
