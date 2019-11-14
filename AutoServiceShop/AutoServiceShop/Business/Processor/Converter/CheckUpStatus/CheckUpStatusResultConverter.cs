using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.CheckUpStatus
{
    class CheckUpStatusResultConverter : BaseResultConverter<Data.Entity.CheckUpStatus, CheckUpStatusResult>, ICheckUpStatusResultConverter
    {
        public CheckUpStatusResult Convert(Data.Entity.CheckUpStatus param)
        {
            CheckUpStatusResult result = new CheckUpStatusResult();

            ConverterStandart(param, result);

            return result;
        }

        public override CheckUpStatusResult ConvertSpecific(Data.Entity.CheckUpStatus param, CheckUpStatusResult result)
        {
            throw new NotImplementedException();
        }
    }
}
