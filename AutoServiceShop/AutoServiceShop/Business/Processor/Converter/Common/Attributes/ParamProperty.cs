using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Common.Attributes
{
    class ParamProperty : Attribute
    {
        public ParamProperty(bool ignore)
        {
            this.Ignore = ignore;
        }

        public ParamProperty(bool ignore, string source, string destination)
        {
            this.Ignore = ignore;
            this.Source = source;
            this.Destination = destination;
        }

        public bool Ignore { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }

        

    }
}
