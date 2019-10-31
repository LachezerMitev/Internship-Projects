using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.CheckUp
{
    interface ICheckUpParamConverter
    {
        AutoServiceShop.Data.Entity.CheckUp Convert(CheckUpParam param, Data.Entity.CheckUp oldentity);
    }
}
