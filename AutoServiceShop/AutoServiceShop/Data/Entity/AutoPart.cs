using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    public class AutoPart : NamedPersistent
    {
<<<<<<< Updated upstream
        public AutoPartStatus AutoPartsStatus { get; set; }
        public double Price { get; set; }
=======
        [ForeignKey("AutoPartStatus")]
        public long? AutoPartStatusId { get; set; }

        public virtual AutoPartStatus AutoPartStatus { get; set; }

        [ForeignKey("CheckUp")]
        public long CheckUpId { get; set; }

        public virtual CheckUp CheckUp { get; set; }

        public decimal Price { get; set; }
>>>>>>> Stashed changes
        public int Quantity { get; set; }
    }
}
