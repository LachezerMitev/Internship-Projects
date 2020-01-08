using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.AutoPartStatus;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;

namespace AutoServiceShop.Presentation.service.AutoPartStatus
{
    public interface IAutoPartStatusService
        : IBaseService<IAutoPartStatusProcessor, IAutoPartStatusParamConverter, IAutoPartStatusResultConverter, AutoPartStatusParam, AutoPartStatusResult, IAutoPartStatusDao, long, Data.Entity.AutoPartStatus>
    {
    }
}
