using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Issue
{
    class IssueResultConverter : IIssueResultConverter
    {
        public IssueResult Convert(Data.Entity.Issue param)
        {
            IssueResult result = new IssueResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }
    }
}
