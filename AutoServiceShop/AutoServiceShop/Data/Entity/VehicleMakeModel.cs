using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    public class VehicleMakeModel : Persistent
    {
        [ForeignKey("Vehicle")]
        public long VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        [ForeignKey("Make")]
        public long MakeId { get; set; }

        public Make Make { get; set; }

        [ForeignKey("Model")]
        public long ModelId { get; set; }

        public Model Model { get; set; }
    }
}
