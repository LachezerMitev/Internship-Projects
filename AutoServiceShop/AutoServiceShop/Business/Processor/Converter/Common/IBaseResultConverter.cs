using AutoServiceShop.Business.Processor.Converter.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Common
{
    interface IBaseResultConverter<Tin, Tout>
    {
        Tout ConverterStandart(Tin param, Tout result);

        Tout ConvertSpecific(Tin param, Tout result);
    }
}
