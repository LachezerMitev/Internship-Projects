using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.AutoPartStatus
{
    class AutoPartStatusResultConverter : BaseResultConverter<Data.Entity.AutoPartStatus, AutoPartStatusResult>, IAutoPartStatusResultConverter
    {
        public AutoPartStatusResult Convert(Data.Entity.AutoPartStatus param)
        {
            AutoPartStatusResult result = new AutoPartStatusResult();

            ConverterStandart(param, result);

            return result;
        }

        public override AutoPartStatusResult ConvertSpecific(Data.Entity.AutoPartStatus param, AutoPartStatusResult result)
        {
            throw new NotImplementedException();
        }
    }
}
