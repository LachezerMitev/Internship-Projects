using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.CheckUpStatus
{
    class CheckUpStatusResultConverter : BaseResultConverter<Data.Entity.CheckUpStatus, CheckUpStatusResult>, ICheckUpStatusResultConverter
    {
        public override void ConvertSpecific(Data.Entity.CheckUpStatus param, CheckUpStatusResult result)
        {
<<<<<<< Updated upstream
            CheckUpStatusResult result = new CheckUpStatusResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
=======
>>>>>>> Stashed changes
        }
    }
}
