using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Make;

namespace AutoServiceShop.Business.Processor.Converter.Make
{
    class MakeParamConverter : IMakeParamConverter
    {
        IMakeDao MakeDao { get; set; }

        public Data.Entity.Make Convert(MakeParam param)
        {
            throw new NotImplementedException();
        }
    }
}
