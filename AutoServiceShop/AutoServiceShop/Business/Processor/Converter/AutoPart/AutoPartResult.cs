using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.AutoPart
{
    class AutoPartResult : BaseResultNamed
    {
        public long AutoPartStatusId { get; set; }

        public string AutopartStatusName { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}
