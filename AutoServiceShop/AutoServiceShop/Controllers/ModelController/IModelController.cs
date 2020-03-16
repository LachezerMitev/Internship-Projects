using AutoServiceShop.Business.Processor.Converter.Model;
using AutoServiceShop.Business.Processor.Model;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.ModelController
{
    interface IModelController
        : IBaseController<IModelProcessor, IModelParamConverter, IModelResultConverter, ModelParam, ModelResult, IModelDao, long, Data.Entity.Model>
    {
    }
}
