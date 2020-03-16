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
<<<<<<< Updated upstream
        IModelDao ModelDao { get; set; }
=======
        public override void ConvertSpecific(ModelParam param, Data.Entity.Model entity) { }
>>>>>>> Stashed changes

        public override Data.Entity.Model GetResult(ModelParam param)
        {
            Data.Entity.Model entity = new Data.Entity.Model
            {
<<<<<<< Updated upstream
                entity = new Data.Entity.Model
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }
=======
                Code = param.Code,
                Id = param.Id,
                Active = param.Active
            };
>>>>>>> Stashed changes

            return entity;
        }
    }
}
