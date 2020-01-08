using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Make
{
    class MakeResultConverter : BaseResultConverter<Data.Entity.Make, MakeResult>, IMakeResultConverter
    {
        public override void ConvertSpecific(Data.Entity.Make param, MakeResult result) { }
    }
}
