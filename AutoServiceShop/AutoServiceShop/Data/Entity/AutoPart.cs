using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class AutoPart : NamedPersistent
    {
<<<<<<< Updated upstream
        public AutoPartStatus AutoPartsStatus { get; set; }
=======
        [ForeignKey("AutoPartStatus")]
        public long AutoPartStatusId { get; set; }

        public virtual AutoPartStatus AutoPartStatus { get; set; }

        [ForeignKey("CheckUp")]
        public long CheckUpId { get; set; }

        public virtual CheckUp CheckUp { get; set; }

>>>>>>> Stashed changes
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
