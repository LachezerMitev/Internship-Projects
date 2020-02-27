using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter
{
    class BaseParam
    {
<<<<<<< Updated upstream
        public int Id { get; set; }
=======
        [ParamProperty(true)]
        public Tid Id { get; set; }
        public sbyte Active { get; set; }
>>>>>>> Stashed changes
    }
}
