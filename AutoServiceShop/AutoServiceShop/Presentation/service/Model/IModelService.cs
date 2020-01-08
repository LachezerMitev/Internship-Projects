using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Dataaccess.Dao.Model;
using AutoServiceShop.Business.Processor.Model;

namespace AutoServiceShop.Presentation.service.Model
{
    public interface IModelService
        : IBaseService<IModelProcessor, IModelParamConverter, IModelResultConverter, ModelParam, ModelResult, IModelDao, long, Data.Entity.Model>
    {
    }
}
