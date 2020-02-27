using System;
using System.Collections.Generic;
<<<<<<< Updated upstream
=======
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> Stashed changes
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class Vehicle : NamedPersistent
    {
<<<<<<< Updated upstream
        public VehicleStatus VehicleStatus { get; set; }

=======
        [ForeignKey("VehicleStatus")]
        public long VehicleStatusId { get; set; }

        public virtual VehicleStatus VehicleStatus { get; set; }

        [DataType(DataType.Date)]
>>>>>>> Stashed changes
        public DateTime DateOfProduction { get; set; }

        public double Mileage { get; set; }

        public Customer Owner { get; set; }
    }
}
