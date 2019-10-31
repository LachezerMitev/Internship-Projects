using AutoServiceShop.Business.Processor.Converter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Model
{
    interface IModelProcessor
    {
        ModelResult Create(ModelParam param);
        List<ModelResult> Create(List<ModelParam> param);

        void Update(long id, ModelParam param);
        void Update(List<ModelParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        ModelResult Find(long id);
        List<ModelResult> Find();
    }
}
