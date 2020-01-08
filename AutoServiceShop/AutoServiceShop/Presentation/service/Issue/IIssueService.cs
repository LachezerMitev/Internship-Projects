using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.Issue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Business.Processor.Issue;
using AutoServiceShop.Dataaccess.Dao.Issue;

namespace AutoServiceShop.Presentation.service.Issue
{
    public interface IIssueService
        : IBaseService<IIssueProcessor, IIssueParamConverter, IIssueResultConverter, IssueParam, IssueResult, IIssueDao, long, Data.Entity.Issue>
    {
    }
}
