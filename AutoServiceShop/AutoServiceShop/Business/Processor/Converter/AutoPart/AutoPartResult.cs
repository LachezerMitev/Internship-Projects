using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.AutoPart
{
    public class AutoPartResult : BaseResultNamed
    {
        public long AutoPartStatusId { get; set; }

        public string AutopartStatusName { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
