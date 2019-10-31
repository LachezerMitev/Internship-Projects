using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.CheckUpStatus
{
    class CheckUpStatusResultConverter : ICheckUpStatusResultConverter
    {
        public CheckUpStatusResult Convert(Data.Entity.CheckUpStatus param)
        {
            CheckUpStatusResult result = new CheckUpStatusResult()
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
