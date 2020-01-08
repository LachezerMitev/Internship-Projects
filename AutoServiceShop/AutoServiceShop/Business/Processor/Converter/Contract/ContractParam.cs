using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Contract
{
    public class ContractParam : BaseParamNamed
    {
        public DateTime WorkDayStart { get; set; }

        public DateTime WorkDayEnd { get; set; }

        public double Salary { get; set; }

        public long ContractStatusId { get; set; }
        public string ContractStatusName { get; set; }

        public long ContractTypeId { get; set; }
        public string ContractTypeName { get; set; }
    }
}
