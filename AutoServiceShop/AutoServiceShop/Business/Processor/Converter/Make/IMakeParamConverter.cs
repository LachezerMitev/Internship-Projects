using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Make
{
    interface IMakeParamConverter
    {
        AutoServiceShop.Data.Entity.Make Convert(MakeParam param, Data.Entity.Make oldentity);
    }
}
