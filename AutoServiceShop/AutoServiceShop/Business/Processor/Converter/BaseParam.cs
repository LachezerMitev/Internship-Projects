using AutoServiceShop.Business.Processor.Converter.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter
{
    public class BaseParam<Tid>
    {
        [ParamProperty(true)]
        public Tid Id { get; set; }
    }
}
