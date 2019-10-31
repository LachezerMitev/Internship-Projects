using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Employee
{
    class EmployeeParam : BaseParamNamed
    {

        public long EmployeeStatusId { get; set; }
        public string EmployeeStatusName { get; set; }

        public long ContractId { get; set; }
        public string ContractName { get; set; }
    }
}
