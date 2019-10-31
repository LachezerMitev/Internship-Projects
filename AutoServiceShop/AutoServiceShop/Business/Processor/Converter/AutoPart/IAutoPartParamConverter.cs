using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.AutoPart
{
    interface IAutoPartParamConverter
    {
        AutoServiceShop.Data.Entity.AutoPart Convert(AutoPartParam param, Data.Entity.AutoPart oldentity);
    }
}
