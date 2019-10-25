using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class Employee : NamedPersistent
    {
        public EmployeeStatus EmployeeStatus { get; set; }
        public Contract Contract { get; set; }
    }
}
