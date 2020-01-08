using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.Make;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.Make;
using AutoServiceShop.Dataaccess.Dao.Make;

namespace AutoServiceShop.Presentation.service.Make
{
    public interface IMakeService
        : IBaseService<IMakeProcessor, IMakeParamConverter, IMakeResultConverter, MakeParam, MakeResult, IMakeDao, long, Data.Entity.Make>
    {
    }
}
