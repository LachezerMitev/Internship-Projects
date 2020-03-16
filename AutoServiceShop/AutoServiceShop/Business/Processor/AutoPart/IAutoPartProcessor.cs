using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.AutoPart;
using AutoServiceShop.Dataaccess.Dao.AutoPart;

namespace AutoServiceShop.Business.Processor.AutoPart
{
    public interface IAutoPartProcessor
        : IBaseProcessor<IAutoPartParamConverter, IAutoPartResultConvert, AutoPartParam, AutoPartResult, IAutoPartDao, long, Data.Entity.AutoPart>
    {
    }
}
