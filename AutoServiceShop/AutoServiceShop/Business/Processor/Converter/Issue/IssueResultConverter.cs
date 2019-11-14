using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Issue
{
    class IssueResultConverter : BaseResultConverter<Data.Entity.Issue, IssueResult>, IIssueResultConverter
    {
        public IssueResult Convert(Data.Entity.Issue param)
        {
            IssueResult result = new IssueResult();

            ConverterStandart(param, result);

            return result;
        }

        public override IssueResult ConvertSpecific(Data.Entity.Issue param, IssueResult result)
        {
            throw new NotImplementedException();
        }
    }
}
