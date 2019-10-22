using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;

namespace AutoServiceShop.Business.Processor.Converter.AutoPartStatus
{
    class AutoPartStatusParamConverter : IAutoPartStatusParamConverter
    {
        IAutoPartStatusDao AutoPartStatusDao { get; set; }

        public Data.Entity.AutoPartStatus Convert(AutoPartStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
