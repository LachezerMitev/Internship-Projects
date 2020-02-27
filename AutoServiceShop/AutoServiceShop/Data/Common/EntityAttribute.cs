using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Common
{
    class EntityAttribute : Attribute
    {
        public EntityAttribute(bool ignore)
        {
            this.Ignore = ignore;
        }

        public EntityAttribute(bool ignore, string source, string destination)
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
