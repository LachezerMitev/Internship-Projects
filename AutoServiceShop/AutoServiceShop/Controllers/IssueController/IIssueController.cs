using AutoServiceShop.Business.Processor.Converter.Issue;
using AutoServiceShop.Business.Processor.Issue;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.Issue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.IssueController
{
    interface IIssueController
        : IBaseController<IIssueProcessor, IIssueParamConverter, IIssueResultConverter, IssueParam, IssueResult, IIssueDao, long, Data.Entity.Issue>
    {
    }
}
