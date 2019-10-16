using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.CheckUpStatus
{
    interface ICheckUpStatusParamConverter
    {
        AutoServiceShop.Data.Entity.CheckUpStatus Convert(CheckUpStatusParam param);
    }
}
