using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;

namespace AutoServiceShop.Business.Processor.Converter.CheckUpStatus
{
    class CheckUpStatusParamConverter : ICheckUpStatusParamConverter
    {
        ICheckUpStatusDao CheckUpStatusDao { get; set; }

        public Data.Entity.CheckUpStatus Convert(CheckUpStatusParam param)
        {
            Data.Entity.CheckUpStatus result = new Data.Entity.CheckUpStatus()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }

        public Data.Entity.CheckUpStatus Convert(CheckUpStatusParam param, Data.Entity.CheckUpStatus oldentity)
        {
            Data.Entity.CheckUpStatus entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.CheckUpStatus();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;

            return entity;
        }
    }
}
