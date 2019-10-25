using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Make
{
    interface IMakeResultConverter
    {
        MakeResult Convert(AutoServiceShop.Data.Entity.Make param);
    }
}
