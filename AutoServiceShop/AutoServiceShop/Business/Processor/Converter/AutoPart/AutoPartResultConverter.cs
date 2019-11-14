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
        public AutoPartResult Convert(Data.Entity.AutoPart param)
        {
            AutoPartResult result = new AutoPartResult();

            ConverterStandart(param, result);

            ConvertSpecific(param, result);

            return result;
        }

        public override AutoPartResult ConvertSpecific(Data.Entity.AutoPart param, AutoPartResult result)
        {
            result.AutoPartStatusId = param.AutoPartsStatus.Id;
            result.AutopartStatusName = param.AutoPartsStatus.Name;

            return result;
        }
    }
}
