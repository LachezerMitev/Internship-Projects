using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Issue;
using AutoServiceShop.Business.Processor.Issue;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Issue
{
    class IssueService : IIssueService
    {
        IIssueProcessor IssueProcessor { get; set; }

        public ApiResponse Create(IssueParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<IssueParam> param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ApiResponse DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse FindByPK(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListAll()
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(long id, IssueParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<IssueParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(IssueParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<IssueParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
