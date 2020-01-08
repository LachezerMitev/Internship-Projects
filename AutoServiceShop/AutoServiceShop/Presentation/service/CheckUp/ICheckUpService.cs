using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.CheckUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.CheckUp;
using AutoServiceShop.Dataaccess.Dao.CheckUp;

namespace AutoServiceShop.Presentation.service.CheckUp
{
    public interface ICheckUpService
        : IBaseService<ICheckUpProcessor, ICheckUpParamConverter, ICheckUpResultConverter, CheckUpParam, CheckUpResult, ICheckUpDao, long, Data.Entity.CheckUp>
    {
    }
}
