using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Issue
{
    interface IIssueParamConverter
    {
        AutoServiceShop.Data.Entity.Issue Convert(IssueParam param, Data.Entity.Issue oldentity);
    }
}
