using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Make;

namespace AutoServiceShop.Business.Processor.Converter.Make
{
    class MakeParamConverter : BaseParamConverter<MakeParam, Data.Entity.Make>, IMakeParamConverter
    {
        IMakeDao MakeDao { get; set; }

        public Data.Entity.Make Convert(MakeParam param, Data.Entity.Make oldentity)
        {
            Data.Entity.Make entity = null;
            
            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.Make
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            return entity;
        }

        public override Data.Entity.Make ConvertSpecific(MakeParam param, Data.Entity.Make entity)
        {
            throw new NotImplementedException();
        }
    }
}
