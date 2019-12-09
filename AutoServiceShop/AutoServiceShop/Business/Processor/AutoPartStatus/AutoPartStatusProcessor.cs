using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;
using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;

namespace AutoServiceShop.Business.Processor.AutoPartStatus
{
    class AutoPartStatusProcessor : IAutoPartStatusProcessor
    {
        private IAutoPartStatusParamConverter _autoPartStatusParamConverter;
        public IAutoPartStatusParamConverter AutoPartStatusParamConverter
        {
            set => _autoPartStatusParamConverter = value;
            get
            {
                if (_autoPartStatusParamConverter == null)
                {
                    _autoPartStatusParamConverter = new AutoPartStatusParamConverter();
                    return _autoPartStatusParamConverter;
                }
                else
                {
                    return _autoPartStatusParamConverter;
                }
            }
        }

        private IAutoPartStatusResultConverter _autoPartStatusResultConverter;
        public IAutoPartStatusResultConverter AutoPartStatusResultConverter
        {
            set => _autoPartStatusResultConverter = value;
            get
            {
                if (_autoPartStatusResultConverter == null)
                {
                    _autoPartStatusResultConverter = new AutoPartStatusResultConverter();
                    return _autoPartStatusResultConverter;
                }
                else
                {
                    return _autoPartStatusResultConverter;
                }
            }
        }

        private IAutoPartStatusDao _AutoPartStatusDao;
        public IAutoPartStatusDao AutoPartStatusDataObject
        {
            set => _AutoPartStatusDao = value;
            get
            {
                if (_AutoPartStatusDao == null)
                {
                    _AutoPartStatusDao = new AutoPartStatusDao();
                    return _AutoPartStatusDao;
                }
                else
                {
                    return _AutoPartStatusDao;
                }
            }
        }


        public AutoPartStatusResult Create(AutoPartStatusParam param)
        {

            Data.Entity.AutoPartStatus entity = _autoPartStatusParamConverter.Convert(param, null);

            _AutoPartStatusDao.Save(entity);

            return _autoPartStatusResultConverter.Convert(entity);
        }

        public List<AutoPartStatusResult> Create(List<AutoPartStatusParam> param)
        {
            List<Data.Entity.AutoPartStatus> entities = new List<Data.Entity.AutoPartStatus>();
            foreach (var item in param)
            {
                entities.Add(_autoPartStatusParamConverter.Convert(item, null));
            }
            _AutoPartStatusDao.Save(entities);
            List<AutoPartStatusResult> result = new List<AutoPartStatusResult>();
            foreach (var item in entities)
            {
                result.Add(_autoPartStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _AutoPartStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.AutoPartStatus> entity = new List<Data.Entity.AutoPartStatus>();
            foreach (var id in idList)
            {
                entity.Add(_AutoPartStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                _AutoPartStatusDao.Delete(id);
            }
        }

        public AutoPartStatusResult Find(long id)
        {
            try
            {
                Data.Entity.AutoPartStatus entity = _AutoPartStatusDao.Find(id);
                AutoPartStatusResult result = _autoPartStatusResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<AutoPartStatusResult> Find()
        {
            List<Data.Entity.AutoPartStatus> AutoPartStatuss = _AutoPartStatusDao.Find();
            List<AutoPartStatusResult> results = new List<AutoPartStatusResult>();
            foreach (var item in AutoPartStatuss)
            {
                results.Add(_autoPartStatusResultConverter.Convert(item));
            }
            return results;
        }

        public List<AutoPartStatusResult> FindByField(string field, string value)
        {
            List<Data.Entity.AutoPartStatus> AutoPartStatuss = _AutoPartStatusDao.FindByField(field, value);
            List<AutoPartStatusResult> results = new List<AutoPartStatusResult>();
            foreach (var item in AutoPartStatuss)
            {
                results.Add(_autoPartStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, AutoPartStatusParam param)
        {
            Data.Entity.AutoPartStatus oldEntity = _AutoPartStatusDao.Find(id);
            Data.Entity.AutoPartStatus newEntity = _autoPartStatusParamConverter.Convert(param, oldEntity);
            _AutoPartStatusDao.Update(newEntity);
        }

        public void Update(List<AutoPartStatusParam> param)
        {
            List<Data.Entity.AutoPartStatus> entity = new List<Data.Entity.AutoPartStatus>();
            foreach (var item in param)
            {
                Data.Entity.AutoPartStatus oldEntity = _AutoPartStatusDao.Find(item.Id);
                Data.Entity.AutoPartStatus newEntity = _autoPartStatusParamConverter.Convert(item, oldEntity);
                _AutoPartStatusDao.Update(newEntity);
            }
        }
    }
}
