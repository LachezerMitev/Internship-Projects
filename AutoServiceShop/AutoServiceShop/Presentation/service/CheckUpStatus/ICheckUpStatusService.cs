using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.CheckUpStatus;
using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;

namespace AutoServiceShop.Presentation.service.CheckUpStatus
{
    public interface ICheckUpStatusService
        : IBaseService<ICheckUpStatusProcessor, ICheckUpStatusParamConverter, ICheckUpStatusResultConverter, CheckUpStatusParam, CheckUpStatusResult, ICheckUpStatusDao, long, Data.Entity.CheckUpStatus>
    {
    }
}
