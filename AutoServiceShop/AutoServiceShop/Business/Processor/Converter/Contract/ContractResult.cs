using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Contract
{
    public class ContractResult : BaseResultNamed
    {
        [DataType(DataType.Time)]
        public DateTime WorkDayStart { get; set; }

        [DataType(DataType.Time)]
        public DateTime WorkDayEnd { get; set; }

        public decimal Salary { get; set; }

        public long ContractStatusId { get; set; }
        public string ContractStatusName { get; set; }

        public long ContractTypeId { get; set; }
        public string ContractTypeName { get; set; }
    }
}
