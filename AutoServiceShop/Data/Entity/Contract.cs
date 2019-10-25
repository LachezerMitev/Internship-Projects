using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class Contract : NamedPersistent
    {
        public DateTime WorkDayStart { get; set; }

        public DateTime WorkDayEnd { get; set; }

        public double Salary { get; set; }

        public ContractStatus ContractStatus { get; set; }

        public ContractType ContractType { get; set; }
    }
}
