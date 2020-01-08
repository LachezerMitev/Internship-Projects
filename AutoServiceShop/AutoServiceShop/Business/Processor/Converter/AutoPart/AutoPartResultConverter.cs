using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.AutoPart
{
    class AutoPartResultConverter : BaseResultConverter<Data.Entity.AutoPart, AutoPartResult>, IAutoPartResultConvert
    {
        public override void ConvertSpecific(Data.Entity.AutoPart param, AutoPartResult result)
        {
            result.AutoPartStatusId = param.AutoPartStatus.Id;
            result.AutopartStatusName = param.AutoPartStatus.Name;
        }
    }
}
