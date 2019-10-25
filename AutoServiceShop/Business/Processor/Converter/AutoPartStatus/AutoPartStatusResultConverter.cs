using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.AutoPartStatus
{
    class AutoPartStatusResultConverter : IAutoPartStatusResultConverter
    {
        public AutoPartStatusResult Convert(Data.Entity.AutoPartStatus param)
        {
            AutoPartStatusResult result = new AutoPartStatusResult()
            {
                Id = param.Id,
                Code = param.Code,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }
    }
}
