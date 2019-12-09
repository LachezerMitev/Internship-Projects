using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.AutoPart;
using AutoServiceShop.Business.Processor.Converter.AutoPart;

namespace AutoServiceShop.Business.Processor.AutoPart
{
    class AutoPartProcessor : IAutoPartProcessor
    {
        private IAutoPartParamConverter _autoPartParamConverter;
        public IAutoPartParamConverter AutoPartParamConverter
        {
            set => _autoPartParamConverter = value;
            get
            {
                if (_autoPartParamConverter == null)
                {
                    _autoPartParamConverter = new AutoPartParamConverter();
                    return _autoPartParamConverter;
                }
                else
                {
                    return _autoPartParamConverter;
                }
            }
        }

        private IAutoPartResultConvert _autoPartResultConverter;
        public IAutoPartResultConvert AutoPartResultConverter
        {
            set => _autoPartResultConverter = value;
            get
            {
                if (_autoPartResultConverter == null)
                {
                    _autoPartResultConverter = new AutoPartResultConverter();
                    return _autoPartResultConverter;
                }
                else
                {
                    return _autoPartResultConverter;
                }
            }
        }

        private IAutoPartDao _autoPartDao;
        public IAutoPartDao AutoPartDataObject
        {
            set => _autoPartDao = value;
            get
            {
                if (_autoPartDao == null)
                {
                    _autoPartDao = new AutoPartDao();
                    return _autoPartDao;
                }
                else
                {
                    return _autoPartDao;
                }
            }
        }


        public AutoPartResult Create(AutoPartParam param)
        {

            Data.Entity.AutoPart entity = _autoPartParamConverter.Convert(param, null);

            _autoPartDao.Save(entity);

            return _autoPartResultConverter.Convert(entity);
        }

        public List<AutoPartResult> Create(List<AutoPartParam> param)
        {
            List<Data.Entity.AutoPart> entities = new List<Data.Entity.AutoPart>();
            foreach (var item in param)
            {
                entities.Add(_autoPartParamConverter.Convert(item, null));
            }
            _autoPartDao.Save(entities);
            List<AutoPartResult> result = new List<AutoPartResult>();
            foreach (var item in entities)
            {
                result.Add(_autoPartResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _autoPartDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.AutoPart> entity = new List<Data.Entity.AutoPart>();
            foreach (var id in idList)
            {
                entity.Add(_autoPartDao.Find(id));
            }
            foreach (var id in idList)
            {
                _autoPartDao.Delete(id);
            }
        }

        public AutoPartResult Find(long id)
        {
            try
            {
                Data.Entity.AutoPart entity = _autoPartDao.Find(id);
                AutoPartResult result = _autoPartResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<AutoPartResult> Find()
        {
            List<Data.Entity.AutoPart> AutoParts = _autoPartDao.Find();
            List<AutoPartResult> results = new List<AutoPartResult>();
            foreach (var item in AutoParts)
            {
                results.Add(_autoPartResultConverter.Convert(item));
            }
            return results;
        }

        public List<AutoPartResult> FindByField(string field, string value)
        {
            List<Data.Entity.AutoPart> AutoParts = _autoPartDao.FindByField(field, value);
            List<AutoPartResult> results = new List<AutoPartResult>();
            foreach (var item in AutoParts)
            {
                results.Add(_autoPartResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, AutoPartParam param)
        {
            Data.Entity.AutoPart oldEntity = _autoPartDao.Find(id);
            Data.Entity.AutoPart newEntity = _autoPartParamConverter.Convert(param, oldEntity);
            _autoPartDao.Update(newEntity);
        }

        public void Update(List<AutoPartParam> param)
        {
            List<Data.Entity.AutoPart> entity = new List<Data.Entity.AutoPart>();
            foreach (var item in param)
            {
                Data.Entity.AutoPart oldEntity = _autoPartDao.Find(item.Id);
                Data.Entity.AutoPart newEntity = _autoPartParamConverter.Convert(item, oldEntity);
                _autoPartDao.Update(newEntity);
            }
        }
    }
}
