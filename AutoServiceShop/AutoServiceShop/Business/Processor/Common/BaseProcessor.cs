using AutoServiceShop.Business.Processor.Converter;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Dataaccess.Dao.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Common
{
    /// <summary>
    /// Base processors that handles all of the data logic
    /// </summary>
    public abstract class BaseProcessor<TParamConverter, TResultConverter, TParam, TResult, TDao, TId, TEntity>
        : IBaseProcessor<TParamConverter, TResultConverter, TParam, TResult, TDao, TId, TEntity>

        where TParamConverter : IBaseParamConverter<TParam, TEntity>
        where TDao : IBaseDao<TEntity, TId>
        where TResultConverter : IBaseResultConverter<TEntity, TResult>
        where TEntity : Data.Entity.Persistent
        where TParam : BaseParam<TId>
    {
        private readonly TDao _dao;

        private readonly TParamConverter _paramConverter;

        private readonly TResultConverter _resultConverter;

        protected BaseProcessor(TDao dao, TParamConverter paramConverter, TResultConverter resultConverter)
        {
            _dao = dao;
            _paramConverter = paramConverter;
            _resultConverter = resultConverter;
        }

        /// <summary>
        /// Saves item
        /// Converts the parameter to entity and passes it to DAO
        /// </summary>
        public TResult Create(TParam param)
        {
            TEntity entity = _paramConverter.Convert(param, null);

            entity = _dao.Save(entity);

            return _resultConverter.Convert(entity);
        }

        public List<TResult> Create(List<TParam> param)
        {
            List<TEntity> entities = new List<TEntity>();

            foreach (var item in param)
            {
                entities.Add(_paramConverter.Convert(item, null));
            }

            _dao.Save(entities);

            List<TResult> result = new List<TResult>();

            entities.ForEach(ent => result.Add(_resultConverter.Convert(ent)));

            return result;
        }

        public void Delete(TId id)
        {
            _dao.Delete(id);
        }

        public void Delete(List<TId> idList)
        {
            List<TEntity> entities = new List<TEntity>();

            foreach (var item in idList)
            {
                entities.Add(_dao.Find(item));
            }

            _dao.Delete(idList);
        }

        public TResult Find(TId id)
        {
            TEntity entity = _dao.Find(id);
            TResult result = _resultConverter.Convert(entity);

            return result;
        }

        public List<TResult> Find()
        {
            List<TEntity> entities = _dao.Find();

            List<TResult> results = new List<TResult>();

            foreach (TEntity item in entities)
            {
                results.Add(_resultConverter.Convert(item));
            }

            return results;
        }

        public List<TResult> Find(string field, string value)
        {
            List<TEntity> accounts = _dao.FindByField(field, value);
            List<TResult> results = new List<TResult>();

            foreach (var item in accounts)
            {
                results.Add(_resultConverter.Convert(item));
            }

            return results;
        }

        public void Update(TId id, TParam param)
        {
            TEntity oldEntity = _dao.Find(id);

            if (oldEntity != null)
            {
                TEntity newEntity = _dao.Update(_paramConverter.Convert(param, oldEntity));
                _dao.Update(newEntity);
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public void Update(List<TParam> param)
        {
            List<TEntity> entities = new List<TEntity>();

            foreach (var item in param)
            {
                TEntity oldEntity = _dao.Find(item.Id);

                if (oldEntity != null)
                {
                    entities.Add(_paramConverter.Convert(item, oldEntity));
                }

                _dao.Update(entities);
            }
        }

        public void ValidateParameters(TParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<TParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
