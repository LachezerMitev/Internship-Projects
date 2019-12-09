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
        private IModelParamConverter _modelParamConverter;
        public IModelParamConverter ModelParamConverter
        {
            set => _modelParamConverter = value;
            get
            {
                if (_modelParamConverter == null)
                {
                    _modelParamConverter = new ModelParamConverter();
                    return _modelParamConverter;
                }
                else
                {
                    return _modelParamConverter;
                }
            }
        }

        private IModelResultConverter _modelResultConverter;
        public IModelResultConverter ModelResultConverter
        {
            set => _modelResultConverter = value;
            get
            {
                if (_modelResultConverter == null)
                {
                    _modelResultConverter = new ModelResultConverrter();
                    return _modelResultConverter;
                }
                else
                {
                    return _modelResultConverter;
                }
            }
        }

        private IModelDao _modelDao;
        public IModelDao ModelDataObject
        {
            set => _modelDao = value;
            get
            {
                if (_modelDao == null)
                {
                    _modelDao = new ModelDao();
                    return _modelDao;
                }
                else
                {
                    return _modelDao;
                }
            }
        }


        public ModelResult Create(ModelParam param)
        {

            Data.Entity.Model entity = _modelParamConverter.Convert(param, null);

            _modelDao.Save(entity);

            return _modelResultConverter.Convert(entity);
        }

        public List<ModelResult> Create(List<ModelParam> param)
        {
            List<Data.Entity.Model> entities = new List<Data.Entity.Model>();
            foreach (var item in param)
            {
                entities.Add(_modelParamConverter.Convert(item, null));
            }
            _modelDao.Save(entities);
            List<ModelResult> result = new List<ModelResult>();
            foreach (var item in entities)
            {
                result.Add(_modelResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _modelDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Model> entity = new List<Data.Entity.Model>();
            foreach (var id in idList)
            {
                entity.Add(_modelDao.Find(id));
            }
            foreach (var id in idList)
            {
                _modelDao.Delete(id);
            }
        }

        public ModelResult Find(long id)
        {
            try
            {
                Data.Entity.Model entity = _modelDao.Find(id);
                ModelResult result = _modelResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<ModelResult> Find()
        {
            List<Data.Entity.Model> Models = _modelDao.Find();
            List<ModelResult> results = new List<ModelResult>();
            foreach (var item in Models)
            {
                results.Add(_modelResultConverter.Convert(item));
            }
            return results;
        }

        public List<ModelResult> FindByField(string field, string value)
        {
            List<Data.Entity.Model> Models = _modelDao.FindByField(field, value);
            List<ModelResult> results = new List<ModelResult>();
            foreach (var item in Models)
            {
                results.Add(_modelResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, ModelParam param)
        {
            Data.Entity.Model oldEntity = _modelDao.Find(id);
            Data.Entity.Model newEntity = _modelParamConverter.Convert(param, oldEntity);
            _modelDao.Update(newEntity);
        }

        public void Update(List<ModelParam> param)
        {
            List<Data.Entity.Model> entity = new List<Data.Entity.Model>();
            foreach (var item in param)
            {
                Data.Entity.Model oldEntity = _modelDao.Find(item.Id);
                Data.Entity.Model newEntity = _modelParamConverter.Convert(item, oldEntity);
                _modelDao.Update(newEntity);
            }
        }
    }
}
