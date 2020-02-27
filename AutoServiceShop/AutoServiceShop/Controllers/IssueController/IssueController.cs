using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.Converter.Issue;
using AutoServiceShop.Business.Processor.Issue;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.Issue;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.IssueController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationIssue]
    public class IssueController
        : BaseController<IIssueProcessor, IIssueParamConverter, IIssueResultConverter, IssueParam, IssueResult, IIssueDao, long, Data.Entity.Issue>, IIssueController
    {
        public IssueController(IIssueProcessor processor) : base(processor)
        {
        }
    }
}
