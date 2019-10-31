using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Model
{
    interface IModelResultConverter
    {
        ModelResult Convert(AutoServiceShop.Data.Entity.Model param);
    }
}
