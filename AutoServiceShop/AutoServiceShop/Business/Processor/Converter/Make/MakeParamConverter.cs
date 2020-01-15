using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Make;

namespace AutoServiceShop.Business.Processor.Converter.Make
{
    class MakeParamConverter : IMakeParamConverter
    {
<<<<<<< Updated upstream
        IMakeDao MakeDao { get; set; }
=======
        
        public override void ConvertSpecific(MakeParam param, Data.Entity.Make entity) { }
>>>>>>> Stashed changes

        public Data.Entity.Make Convert(MakeParam param, Data.Entity.Make oldentity)
        {
            Data.Entity.Make entity = null;
            
            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.Make
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            return entity;
        }
    }
}
