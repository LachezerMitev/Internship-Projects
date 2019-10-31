using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class Vehicle : NamedPersistent
    {
        public VehicleStatus VehicleStatus { get; set; }

        public DateTime DateOfProduction { get; set; }

        public double Mileage { get; set; }

        public Customer Owner { get; set; }
    }
}
