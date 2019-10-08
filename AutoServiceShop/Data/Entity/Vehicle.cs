using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class Vehicle : NamedPersistent
    {
        VehicleStatus VehicleStatus { get; set; }
        DateTime DateOfProduction { get; set; }
        double Mileage { get; set; }
        Customer Owner { get; set; }
    }
}
