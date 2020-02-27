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
    class Contract : NamedPersistent
    {
        [DataType(DataType.Time)]
        public DateTime WorkDayStart { get; set; }

        [DataType(DataType.Time)]
        public DateTime WorkDayEnd { get; set; }

        public double Salary { get; set; }

<<<<<<< Updated upstream
        public ContractStatus ContractStatus { get; set; }

        public ContractType ContractType { get; set; }
=======
        [ForeignKey("ContractStatus")]
        public long ContractStatusId { get; set; }

        public virtual ContractStatus ContractStatus { get; set; }

        [ForeignKey("ContractType")]
        public long ContractTypeId { get; set; }

        public virtual ContractType ContractType { get; set; }
>>>>>>> Stashed changes
    }
}
