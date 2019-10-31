using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Vehicle
{
    class VehicleResult : BaseResultNamed
    {
        public long VehicleStatusId { get; set; }
        public string VehicleStatusName { get; set; }

        public DateTime DateOfProduction { get; set; }

        public double Mileage { get; set; }

        public long OwnerId { get; set; }
        public string OwnerName { get; set; }
    }
}
