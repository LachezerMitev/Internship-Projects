using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Customer
{
    class CustomerResult : BaseResultNamed
    {
        public Data.Entity.CustomerStatus CustomerStatus { get; set; }
    }
}
