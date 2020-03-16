using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;

namespace AutoServiceShop.Business.Processor.AutoPartStatus
{
    public interface IAutoPartStatusProcessor
        : IBaseProcessor<IAutoPartStatusParamConverter, IAutoPartStatusResultConverter, AutoPartStatusParam, AutoPartStatusResult, IAutoPartStatusDao, long, Data.Entity.AutoPartStatus>
    {
    }
}
