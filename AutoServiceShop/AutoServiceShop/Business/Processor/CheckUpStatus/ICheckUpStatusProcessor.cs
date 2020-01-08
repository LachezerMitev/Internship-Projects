using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;
using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.CheckUpStatus
{
    public interface ICheckUpStatusProcessor
        : IBaseProcessor<ICheckUpStatusParamConverter, ICheckUpStatusResultConverter, CheckUpStatusParam, CheckUpStatusResult, ICheckUpStatusDao, long, Data.Entity.CheckUpStatus>
    {
    }
}
