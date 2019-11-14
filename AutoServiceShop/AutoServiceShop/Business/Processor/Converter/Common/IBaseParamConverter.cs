using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Common
{
    interface IBaseParamConverter<Tin, Tout>
    {
        Tout ConverterStandart(Tin param, Tout entity);

        Tout ConvertSpecific(Tin param, Tout entity);
    }
}
