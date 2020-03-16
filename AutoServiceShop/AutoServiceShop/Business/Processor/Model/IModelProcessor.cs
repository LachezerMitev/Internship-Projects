using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.Model;
using AutoServiceShop.Dataaccess.Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Model
{
    public interface IModelProcessor
        : IBaseProcessor<IModelParamConverter, IModelResultConverter, ModelParam, ModelResult, IModelDao, long, Data.Entity.Model>
    {
    }
}
