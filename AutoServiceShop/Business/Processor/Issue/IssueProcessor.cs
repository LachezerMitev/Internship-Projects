using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Issue;
using AutoServiceShop.Business.Processor.Converter.Issue;

namespace AutoServiceShop.Business.Processor.Issue
{
    class IssueProcessor : IIssueProcessor
    {
        IIssueDao IssueDao { get; set; }

        IIssueParamConverter IssueParamConverter { get; set; }
        IIssueResultConverter IssueResultConverter { get; set; }

        public IssueResult Create(IssueParam param)
        {
            throw new NotImplementedException();
        }

        public List<IssueResult> Create(List<IssueParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public IssueResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<IssueResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, IssueParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<IssueParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
