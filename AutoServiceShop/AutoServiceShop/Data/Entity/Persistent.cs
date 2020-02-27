using AutoServiceShop.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class Persistent
    {
<<<<<<< Updated upstream
=======
        [EntityAttribute(true)]
        [Key]
>>>>>>> Stashed changes
        public long Id { get; set; }

        public sbyte Active { get; set; }
    }
}
