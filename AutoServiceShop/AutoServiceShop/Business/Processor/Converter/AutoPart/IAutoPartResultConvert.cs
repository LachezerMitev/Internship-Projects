using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.AutoPart
{
    interface IAutoPartResultConvert
    {
        AutoPartResult Convert(AutoServiceShop.Data.Entity.AutoPart param);
    }
}
