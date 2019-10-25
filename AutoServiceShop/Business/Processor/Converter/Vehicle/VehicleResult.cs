using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Vehicle
{
    class VehicleResult : BaseResultNamed
    {
        public Data.Entity.VehicleStatus VehicleStatus { get; set; }

        public DateTime DateOfProduction { get; set; }

        public double Mileage { get; set; }

        public Data.Entity.Customer Owner { get; set; }
    }
}
