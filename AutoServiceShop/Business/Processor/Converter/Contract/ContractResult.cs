using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Contract
{
    class ContractResult : BaseResultNamed
    {
        public DateTime WorkDayStart { get; set; }

        public DateTime WorkDayEnd { get; set; }

        public double Salary { get; set; }

        public Data.Entity.ContractStatus ContractStatus { get; set; }

        public Data.Entity.ContractType ContractType { get; set; }
    }
}
