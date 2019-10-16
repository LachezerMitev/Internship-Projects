using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop
{
    class CheckUp : NamedPersistent
    {
        CheckUpStatus CheckUpStatus { get; set; }
        double Price { get; set; }
        List<AutoPart> PartList { get; set; }
        DateTime CheckUpStart { get; set; }
        DateTime CheckUpEnd { get; set; }
        List<Issue> IssueList { get; set; }
        Employee Employee { get; set; }
        Customer Customer { get; set; }
        Vehicle Vehicle { get; set; }
    }
}
