using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Issue;

namespace AutoServiceShop.Business.Processor.Converter.Issue
{
    class IssueParamConverter : BaseParamConverter<IssueParam, Data.Entity.Issue>, IIssueParamConverter
    {
<<<<<<< Updated upstream
        IIssueDao IssueDao = new IssueDao();
=======
        public override void ConvertSpecific(IssueParam param, Data.Entity.Issue entity) { }
>>>>>>> Stashed changes

        public override Data.Entity.Issue GetResult(IssueParam param)
        {
            Data.Entity.Issue entity = new Data.Entity.Issue
            {
                Code = param.Code,
                Id = param.Id,
            };

            return entity;
        }
    }
}
