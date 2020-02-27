using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Issue;

namespace AutoServiceShop.Business.Processor.Converter.Issue
{
    class IssueParamConverter : IIssueParamConverter
    {
<<<<<<< Updated upstream
        IIssueDao IssueDao = new IssueDao();
=======
        public override void ConvertSpecific(IssueParam param, Data.Entity.Issue entity) { }
>>>>>>> Stashed changes

        public Data.Entity.Issue Convert(IssueParam param, Data.Entity.Issue oldentity)
        {
            Data.Entity.Issue entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.Issue
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            return entity;
        }
    }
}
