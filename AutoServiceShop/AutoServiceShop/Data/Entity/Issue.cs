using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    public class Issue : NamedPersistent
    {
        [ForeignKey("CheckUp")]
        public long CheckUpId { get; set; }

        public CheckUp CheckUp { get; set; }
    }
}
