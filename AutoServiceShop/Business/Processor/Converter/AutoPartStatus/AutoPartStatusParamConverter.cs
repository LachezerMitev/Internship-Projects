using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;

namespace AutoServiceShop.Business.Processor.Converter.AutoPartStatus
{
    class AutoPartStatusParamConverter : IAutoPartStatusParamConverter
    {
        IAutoPartStatusDao AutoPartStatusDao { get; set; }

        public Data.Entity.AutoPartStatus Convert(AutoPartStatusParam param)
        {
            Data.Entity.AutoPartStatus result = new Data.Entity.AutoPartStatus()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }

        public Data.Entity.AutoPartStatus Convert(AutoPartStatusParam param, Data.Entity.AutoPartStatus oldentity)
        {
            Data.Entity.AutoPartStatus entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.AutoPartStatus();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;

            return entity;
        }
    }
}
