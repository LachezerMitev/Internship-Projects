using AutoServiceShop.Business.Processor.Converter.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter
{
    public class BaseParamNamed : BaseParam<long>
    {
<<<<<<< Updated upstream
=======
        [ParamProperty(true, "UniCode", "Code")]
>>>>>>> Stashed changes
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
