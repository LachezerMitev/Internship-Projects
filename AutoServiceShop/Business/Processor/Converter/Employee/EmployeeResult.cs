using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Employee
{
    class EmployeeResult : BaseResultNamed
    {
        public Data.Entity.EmployeeStatus EmployeeStatus { get; set; }
        public Data.Entity.Contract Contract { get; set; }
    }
}
