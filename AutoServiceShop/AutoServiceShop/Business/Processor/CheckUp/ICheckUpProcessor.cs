using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.CheckUp;
using AutoServiceShop.Dataaccess.Dao.CheckUp;

namespace AutoServiceShop.Business.Processor.CheckUp
{
    public interface ICheckUpProcessor
        : IBaseProcessor<ICheckUpParamConverter, ICheckUpResultConverter, CheckUpParam, CheckUpResult, ICheckUpDao, long, Data.Entity.CheckUp>
    {
    }
}
