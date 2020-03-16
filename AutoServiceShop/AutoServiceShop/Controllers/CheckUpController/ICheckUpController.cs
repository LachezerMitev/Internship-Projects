using AutoServiceShop.Business.Processor.CheckUp;
using AutoServiceShop.Business.Processor.Converter.CheckUp;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.CheckUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.CheckUpController
{
    interface ICheckUpController
        : IBaseController<ICheckUpProcessor, ICheckUpParamConverter, ICheckUpResultConverter, CheckUpParam, CheckUpResult, ICheckUpDao, long, Data.Entity.CheckUp>
    {
    }
}
