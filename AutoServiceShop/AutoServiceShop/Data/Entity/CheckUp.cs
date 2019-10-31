using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class CheckUp : NamedPersistent
    {
        public CheckUpStatus CheckUpStatus { get; set; }

        public double Price { get; set; }

        public List<AutoPart> PartList { get; set; }

        public DateTime CheckUpStart { get; set; }

        public DateTime CheckUpEnd { get; set; }

        public List<Issue> IssueList { get; set; }

        public Employee Employee { get; set; }

        public Customer Customer { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
