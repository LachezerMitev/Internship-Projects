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
<<<<<<< Updated upstream
        IMakeDao MakeDao { get; set; }
=======
        
        public override void ConvertSpecific(MakeParam param, Data.Entity.Make entity) { }
>>>>>>> Stashed changes

        public override Data.Entity.Make GetResult(MakeParam param)
        {
            Data.Entity.Make entity = new Data.Entity.Make
            {
                Code = param.Code,
                Id = param.Id,
            };

            return entity;
        }
    }
}
