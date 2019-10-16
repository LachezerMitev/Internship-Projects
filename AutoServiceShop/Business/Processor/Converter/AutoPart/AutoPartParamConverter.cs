using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.AutoPart;

namespace AutoServiceShop.Business.Processor.Converter.AutoPart
{
    class AutoPartParamConverter : IAutoPartParamConverter
    {
        AutoPartDao AutoPartDao { get; set; }

        public Data.Entity.AutoPart Convert(AutoPartParam param)
        {
            throw new NotImplementedException();
        }
    }
}
