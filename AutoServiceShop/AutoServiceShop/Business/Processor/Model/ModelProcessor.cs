using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Model;
using AutoServiceShop.Business.Processor.Converter.Model;
using AutoServiceShop.Business.Processor.Common;

namespace AutoServiceShop.Business.Processor.Model
{
    public class ModelProcessor
        : BaseProcessor<IModelParamConverter, IModelResultConverter, ModelParam, ModelResult, IModelDao, long, Data.Entity.Model>, IModelProcessor
    {
<<<<<<< Updated upstream
        IModelDao ModelDao = new ModelDao();

        IModelParamConverter ModelParamConverter = new ModelParamConverter();
        IModelResultConverter ModelResultConverrter = new ModelResultConverrter();

        public ModelResult Create(ModelParam param)
        {
            Data.Entity.Model entity = ModelParamConverter.Convert(param, null);
            ModelDao.Save(entity);

            return ModelResultConverrter.Convert(entity);
        }

        public List<ModelResult> Create(List<ModelParam> param)
        {
            List<Data.Entity.Model> entities = new List<Data.Entity.Model>();
            foreach (var item in param)
            {
                entities.Add(ModelParamConverter.Convert(item, null));
            }
            ModelDao.Save(entities);
            List<ModelResult> result = new List<ModelResult>();
            foreach (var item in entities)
            {
                result.Add(ModelResultConverrter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            ModelDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Model> entity = new List<Data.Entity.Model>();
            foreach (var id in idList)
            {
                entity.Add(ModelDao.Find(id));
            }
            foreach (var id in idList)
            {
                ModelDao.Delete(id);
            }
        }

        public ModelResult Find(long id)
        {
            Data.Entity.Model entity = ModelDao.Find(id);
            ModelResult result = ModelResultConverrter.Convert(entity);
            return result;
        }

        public List<ModelResult> Find()
        {
            List<Data.Entity.Model> entity = ModelDao.Find();
            List<ModelResult> results = new List<ModelResult>();
            foreach (var item in entity)
            {
                results.Add(ModelResultConverrter.Convert(item));
            }
            return results;
        }

        public void Update(long id, ModelParam param)
        {
            Data.Entity.Model oldEntity = ModelDao.Find(id);
            Data.Entity.Model newEntity = ModelParamConverter.Convert(param, null);
            ModelDao.Update(newEntity);
        }

        public void Update(List<ModelParam> param)
=======
        public ModelProcessor(IModelDao dao, IModelParamConverter paramConverter, IModelResultConverter resultConverter) : base(dao, paramConverter, resultConverter)
>>>>>>> Stashed changes
        {
        }
    }
}
