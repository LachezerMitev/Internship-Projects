using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop
{
    class Contract : NamedPersistent
    {
        DateTime WorkDayStart { get; set; }
        DateTime WorkDayEnd { get; set; }
        double Salary { get; set; }
        ContractStatus ContractStatus { get; set; }
        ContractType ContractType { get; set; }
    }
}
