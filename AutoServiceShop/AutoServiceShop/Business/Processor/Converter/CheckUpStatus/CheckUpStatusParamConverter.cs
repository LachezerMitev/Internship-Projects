using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;

namespace AutoServiceShop.Business.Processor.Converter.CheckUpStatus
{
    class CheckUpStatusParamConverter : BaseParamConverter<CheckUpStatusParam, Data.Entity.CheckUpStatus>, ICheckUpStatusParamConverter
    {
        ICheckUpStatusDao CheckUpStatusDao = new CheckUpStatusDao();

        public Data.Entity.CheckUpStatus Convert(CheckUpStatusParam param, Data.Entity.CheckUpStatus oldentity)
        {
            Data.Entity.CheckUpStatus entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                {
                    entity = oldentity;
                }
                else
                {
                    throw new Exception("You have changed either the ID or the description");
                }
            }
            else
            {
                entity = new Data.Entity.CheckUpStatus
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            return entity;
        }

        public override Data.Entity.CheckUpStatus ConvertSpecific(CheckUpStatusParam param, Data.Entity.CheckUpStatus entity)
        {
            throw new NotImplementedException();
        }
    }
}
