using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Model
{
    class ModelResultConverrter : IModelResultConverter
    {
        public ModelResult Convert(Data.Entity.Model param)
        {
            ModelResult result = new ModelResult()
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
