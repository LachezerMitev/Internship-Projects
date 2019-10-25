using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Make
{
    class MakeResultConverter : IMakeResultConverter
    {
        public MakeResult Convert(Data.Entity.Make param)
        {
            MakeResult result = new MakeResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }
    }
}
