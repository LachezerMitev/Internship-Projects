using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Model
{
    class ModelResultConverrter : BaseResultConverter<Data.Entity.Model, ModelResult>, IModelResultConverter
    {
        public override void ConvertSpecific(Data.Entity.Model param, ModelResult result) { }
    }
}
