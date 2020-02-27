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
    class CheckUp : NamedPersistent
    {
<<<<<<< Updated upstream
        public CheckUpStatus CheckUpStatus { get; set; }

        public double Price { get; set; }

        public List<AutoPart> PartList { get; set; }

=======
        [ForeignKey("CheckUpStatus")]
        public long CheckUpStatusId { get; set; }

        public virtual CheckUpStatus CheckUpStatus { get; set; }

        public decimal Price { get; set; }

        [DataType(DataType.Date)]
>>>>>>> Stashed changes
        public DateTime CheckUpStart { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckUpEnd { get; set; }

<<<<<<< Updated upstream
        public List<Issue> IssueList { get; set; }

        public Employee Employee { get; set; }

        public Customer Customer { get; set; }

        public Vehicle Vehicle { get; set; }
=======
        [ForeignKey("Vehicle")]
        public long? VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public long? CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Account Customer { get; set; }
>>>>>>> Stashed changes
    }
}
