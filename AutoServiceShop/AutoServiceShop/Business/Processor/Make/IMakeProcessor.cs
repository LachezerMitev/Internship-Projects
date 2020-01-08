using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.Make;
using AutoServiceShop.Dataaccess.Dao.Make;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Make
{
    public interface IMakeProcessor
        : IBaseProcessor<IMakeParamConverter, IMakeResultConverter, MakeParam, MakeResult, IMakeDao, long, Data.Entity.Make>
    {
    }
}
