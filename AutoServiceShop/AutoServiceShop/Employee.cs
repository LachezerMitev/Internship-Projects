using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop
{
    class Employee : NamedPersistent
    {
        EmployeeStatus EmployeeStatus { get; set; }
        Contract Contract { get; set; }
    }
}
