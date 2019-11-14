using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;

namespace AutoServiceShop.Business.Processor.Converter.AutoPartStatus
{
    class AutoPartStatusParamConverter : BaseParamConverter<AutoPartStatusParam, Data.Entity.AutoPartStatus>, IAutoPartStatusParamConverter
    {
        IAutoPartStatusDao AutoPartStatusDao = new AutoPartStatusDao();

        public Data.Entity.AutoPartStatus Convert(AutoPartStatusParam param, Data.Entity.AutoPartStatus oldentity)
        {
            Data.Entity.AutoPartStatus entity = null;

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
                entity = new Data.Entity.AutoPartStatus
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            return entity;
        }

        public override Data.Entity.AutoPartStatus ConvertSpecific(AutoPartStatusParam param, Data.Entity.AutoPartStatus entity)
        {
            throw new NotImplementedException();
        }
    }
}
