using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;

namespace AutoServiceShop.Business.Processor.Converter.CheckUpStatus
{
    class CheckUpStatusParamConverter : ICheckUpStatusParamConverter
    {
        CheckUpStatusDao CheckUpStatusDao { get; set; }

        public Data.Entity.CheckUpStatus Convert(CheckUpStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
