using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Issue;

namespace AutoServiceShop.Business.Processor.Converter.Issue
{
    class IssueParamConverter : IIssueParamConverter
    {
        IssueDao IssueDao { get; set; }

        public Data.Entity.Issue Convert(IssueParam param)
        {
            throw new NotImplementedException();
        }
    }
}
