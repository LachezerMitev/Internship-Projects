using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    public class Vehicle : NamedPersistent
    {
        [ForeignKey("VehicleStatus")]
        public long VehicleStatusId { get; set; }

        public VehicleStatus VehicleStatus { get; set; }

        public DateTime DateOfProduction { get; set; }

        public double Mileage { get; set; }
    }
}
