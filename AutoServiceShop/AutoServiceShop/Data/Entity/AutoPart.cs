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
        [ForeignKey("AutoPartStatus")]
        public long AutoPartStatusId { get; set; }

        public AutoPartStatus AutoPartStatus { get; set; }

        [ForeignKey("CheckUp")]
        public long CheckUpId { get; set; }

        public CheckUp CheckUp { get; set; }

        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
