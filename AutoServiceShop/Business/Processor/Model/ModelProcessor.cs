using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Model;
using AutoServiceShop.Business.Processor.Converter.Model;

namespace AutoServiceShop.Business.Processor.Model
{
    class ModelProcessor : IModelProcessor
    {
        ModelDao ModelDao { get; set; }

        ModelParamConverter ModelParamConverter { get; set; }
        ModelResultConverrter ModelResultConverrter { get; set; }

        public ModelResult Create(ModelParam param)
        {
            throw new NotImplementedException();
        }

        public List<ModelResult> Create(List<ModelParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ModelResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<ModelResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, ModelParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<ModelParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
