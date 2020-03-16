using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.Issue;
using AutoServiceShop.Dataaccess.Dao.Issue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Issue
{
    public interface IIssueProcessor
        : IBaseProcessor<IIssueParamConverter, IIssueResultConverter, IssueParam, IssueResult, IIssueDao, long, Data.Entity.Issue>
    {
    }
}
