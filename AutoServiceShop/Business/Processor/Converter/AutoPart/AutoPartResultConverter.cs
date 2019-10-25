using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.AutoPart
{
    class AutoPartResultConverter : IAutoPartResultConvert
    {
        public AutoPartResult Convert(Data.Entity.AutoPart param)
        {
            AutoPartResult result = new AutoPartResult()
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
    }
}
