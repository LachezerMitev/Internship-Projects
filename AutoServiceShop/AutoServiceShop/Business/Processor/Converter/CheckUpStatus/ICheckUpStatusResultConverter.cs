using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.CheckUpStatus
{
    interface ICheckUpStatusResultConverter
    {
        CheckUpStatusResult Convert(AutoServiceShop.Data.Entity.CheckUpStatus param);
    }
}
