using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Model;

namespace AutoServiceShop.Business.Processor.Converter.Model
{
    class ModelParamConverter : BaseParamConverter<ModelParam, Data.Entity.Model>, IModelParamConverter
    {
        IModelDao ModelDao { get; set; }

        public Data.Entity.Model Convert(ModelParam param, Data.Entity.Model oldentity)
        {
            Data.Entity.Model entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.Model
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            return entity;
        }

        public override Data.Entity.Model ConvertSpecific(ModelParam param, Data.Entity.Model entity)
        {
            throw new NotImplementedException();
        }
    }
}
