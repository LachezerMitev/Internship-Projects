using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.AutoPart;

namespace AutoServiceShop.Business.Processor.Converter.AutoPart
{
    class AutoPartParamConverter : IAutoPartParamConverter
    {
        IAutoPartDao AutoPartDao { get; set; }

        public Data.Entity.AutoPart Convert(AutoPartParam param)
        {
            Data.Entity.AutoPart result = new Data.Entity.AutoPart()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,
                AutoPartsStatus = param.AutoPartsStatus,
                Price = param.Price,
                Quantity = param.Quantity
            };

            return result;

        }

        public Data.Entity.AutoPart Convert(AutoPartParam param, Data.Entity.AutoPart oldentity)
        {
            Data.Entity.AutoPart entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.AutoPart();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;
            entity.AutoPartsStatus = param.AutoPartsStatus;
            entity.Price = param.Price;
            entity.Quantity = param.Quantity;

            return entity;
        }
    }
}
