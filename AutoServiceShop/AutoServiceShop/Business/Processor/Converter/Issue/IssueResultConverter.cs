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
        public override void ConvertSpecific(Data.Entity.Issue param, IssueResult result) { }
    }
}
