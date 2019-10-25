using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Model;

namespace AutoServiceShop.Business.Processor.Converter.Model
{
    class ModelParamConverter : IModelParamConverter
    {
        IModelDao ModelDao { get; set; }

        public Data.Entity.Model Convert(ModelParam param)
        {
            Data.Entity.Model result = new Data.Entity.Model()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }

        public Data.Entity.Model Convert(ModelParam param, Data.Entity.Model oldentity)
        {
            Data.Entity.Model entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.Model();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;

            return entity;
        }
    }
}
