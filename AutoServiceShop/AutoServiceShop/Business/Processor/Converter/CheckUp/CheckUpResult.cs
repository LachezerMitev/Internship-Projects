using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.CheckUp
{
    class CheckUpResult : BaseResultNamed
    {

        public long CheckUpStatusId { get; set; }

        public string CheckUpStatusName { get; set; }

        public double Price { get; set; }

        public DateTime CheckUpEnd { get; set; }

        public DateTime CheckUpStart { get; set; }

        public long CustomerId { get; set; }

        public string CustomerName { get; set; }

        public long VehicleId { get; set; }

        public string VehicleName { get; set; }
    }
}
