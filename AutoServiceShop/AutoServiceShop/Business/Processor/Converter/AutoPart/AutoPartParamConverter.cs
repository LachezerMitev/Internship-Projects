using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.AutoPart;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;

namespace AutoServiceShop.Business.Processor.Converter.AutoPart
{
    class AutoPartParamConverter : BaseParamConverter<AutoPartParam, Data.Entity.AutoPart>, IAutoPartParamConverter
    {
        IAutoPartDao AutoPartDao = new AutoPartDao();
        IAutoPartStatusDao AutoPartStatusDao = new AutoPartStatusDao();

        public Data.Entity.AutoPart Convert(AutoPartParam param, Data.Entity.AutoPart oldentity)
        {
            Data.Entity.AutoPart entity = null;

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
                entity = new Data.Entity.AutoPart
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.AutoPart ConvertSpecific(AutoPartParam param, Data.Entity.AutoPart entity)
        {
            entity.AutoPartsStatus = AutoPartStatusDao.Find(param.AutoPartStatusId);

            return entity;
        }
    }
}
