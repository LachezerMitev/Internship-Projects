using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.AutoPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.AutoPart;
using AutoServiceShop.Dataaccess.Dao.AutoPart;

namespace AutoServiceShop.Presentation.service.AutoPart
{
    public interface IAutoPartService
        : IBaseService<IAutoPartProcessor, IAutoPartParamConverter, IAutoPartResultConvert, AutoPartParam, AutoPartResult, IAutoPartDao, long, Data.Entity.AutoPart>
    {

    }
}
