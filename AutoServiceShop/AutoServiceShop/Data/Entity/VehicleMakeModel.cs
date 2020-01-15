using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class VehicleMakeModel : Persistent
    {
<<<<<<< Updated upstream
        public Vehicle Vehicle { get; set; }

        public Make Make { get; set; }

        public Model Model { get; set; }
=======
        [ForeignKey("Vehicle")]
        public long VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        [ForeignKey("Make")]
        public long MakeId { get; set; }

        public virtual Make Make { get; set; }

        [ForeignKey("Model")]
        public long ModelId { get; set; }

        public virtual Model Model { get; set; }
>>>>>>> Stashed changes
    }
}
