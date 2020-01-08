using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.CheckUp
{
    public class CheckUpResult : BaseResultNamed
    {

        public long CheckUpStatusId { get; set; }

        public string CheckUpStatusName { get; set; }

        public double Price { get; set; }

        public List<Data.Entity.AutoPart> PartList { get; set; }

        public DateTime CheckUpEnd { get; set; }

        public DateTime CheckUpStart { get; set; }

        public List<Data.Entity.Issue> IssueList { get; set; }

        public long EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public long CustomerId { get; set; }

        public string CustomerName { get; set; }

        public long VehicleId { get; set; }

        public string VehicleName { get; set; }
    }
}
