using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
<<<<<<< Updated upstream
    class Issue : NamedPersistent
    { 
=======
    public class Issue : NamedPersistent
    {
        [ForeignKey("CheckUp")]
        public long CheckUpId { get; set; }

        public virtual CheckUp CheckUp { get; set; }
>>>>>>> Stashed changes
    }
}
