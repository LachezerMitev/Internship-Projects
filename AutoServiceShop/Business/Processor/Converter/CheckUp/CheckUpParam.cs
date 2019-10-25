using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoServiceShop.Business.Processor.Converter.CheckUp
{
    class CheckUpParam : BaseParamNamed
    {
        public Data.Entity.CheckUpStatus CheckUpStatus { get; set; }

        public double Price { get; set; }

        public List<Data.Entity.AutoPart> PartList { get; set; }

        public DateTime CheckUpEnd { get; set; }

        public DateTime CheckUpStart { get; set; }

        public List<Data.Entity.Issue> IssueList { get; set; }

        public Data.Entity.Employee Employee { get; set; }

        public Data.Entity.Customer Customer { get; set; }

        public Data.Entity.Vehicle Vehicle { get; set; }
    }
}
