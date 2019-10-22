using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.CheckUp;

namespace AutoServiceShop.Business.Processor.Converter.CheckUp
{
    class CheckUpParamConverter : ICheckUpParamConverter
    {
        ICheckUpDao CheckUpDao { get; set; }

        public Data.Entity.CheckUp Convert(CheckUpParam param)
        {
            throw new NotImplementedException();
        }
    }
}
