using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    public class Contract : NamedPersistent
    {
        public DateTime WorkDayStart { get; set; }

        public DateTime WorkDayEnd { get; set; }

        public double Salary { get; set; }

        [ForeignKey("ContractStatus")]
        public long ContractStatusId { get; set; }

        public ContractStatus ContractStatus { get; set; }

        [ForeignKey("ContractType")]
        public long ContractTypeId { get; set; }

        public ContractType ContractType { get; set; }
    }
}
