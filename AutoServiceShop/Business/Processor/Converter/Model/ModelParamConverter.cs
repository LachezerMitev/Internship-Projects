using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Model;

namespace AutoServiceShop.Business.Processor.Converter.Model
{
    class ModelParamConverter : IModelParamConverter
    {
        IModelDao ModelDao { get; set; }

        public Data.Entity.Model Convert(ModelParam param)
        {
            throw new NotImplementedException();
        }
    }
}
