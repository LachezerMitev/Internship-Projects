using AutoServiceShop.Business.Processor.Converter.Issue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Issue
{
    interface IIssueProcessor
    {
        IssueResult Create(IssueParam param);
        List<IssueResult> Create(List<IssueParam> param);

        void Update(long id, IssueParam param);
        void Update(List<IssueParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        IssueResult Find(long id);
        List<IssueResult> Find();
    }
}
