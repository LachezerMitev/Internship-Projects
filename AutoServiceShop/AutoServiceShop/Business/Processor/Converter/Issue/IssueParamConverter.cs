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
        IIssueDao IssueDao = new IssueDao();

        public Data.Entity.Issue Convert(IssueParam param, Data.Entity.Issue oldentity)
        {
            Data.Entity.Issue entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.Issue
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            return entity;
        }

        public override Data.Entity.Issue ConvertSpecific(IssueParam param, Data.Entity.Issue entity)
        {
            throw new NotImplementedException();
        }
    }
}
