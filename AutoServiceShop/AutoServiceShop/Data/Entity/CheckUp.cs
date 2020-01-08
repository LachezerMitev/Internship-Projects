using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    public class CheckUp : NamedPersistent
    {
        [ForeignKey("CheckUpStatus")]
        public long CheckUpStatusId { get; set; }

        public CheckUpStatus CheckUpStatus { get; set; }

        public double Price { get; set; }

        public DateTime CheckUpStart { get; set; }

        public DateTime CheckUpEnd { get; set; }

        [ForeignKey("Vehicle")]
        public long VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        public long CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Account Customer { get; set; }
    }
}
