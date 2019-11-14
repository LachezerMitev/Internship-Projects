using AutoServiceShop.Business.Processor.Converter.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter
{
    class BaseParamNamed : BaseParam
    {
        [ParamProperty(true)]
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
