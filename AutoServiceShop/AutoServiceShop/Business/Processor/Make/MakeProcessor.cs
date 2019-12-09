using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Make;
using AutoServiceShop.Business.Processor.Converter.Make;

namespace AutoServiceShop.Business.Processor.Make
{
    class MakeProcessor : IMakeProcessor
    {
        private IMakeParamConverter _makeParamConverter;
        public IMakeParamConverter MakeParamConverter
        {
            set => _makeParamConverter = value;
            get
            {
                if (_makeParamConverter == null)
                {
                    _makeParamConverter = new MakeParamConverter();
                    return _makeParamConverter;
                }
                else
                {
                    return _makeParamConverter;
                }
            }
        }

        private IMakeResultConverter _makeResultConverter;
        public IMakeResultConverter MakeResultConverter
        {
            set => _makeResultConverter = value;
            get
            {
                if (_makeResultConverter == null)
                {
                    _makeResultConverter = new MakeResultConverter();
                    return _makeResultConverter;
                }
                else
                {
                    return _makeResultConverter;
                }
            }
        }

        private IMakeDao _makeDao;
        public IMakeDao MakeDataObject
        {
            set => _makeDao = value;
            get
            {
                if (_makeDao == null)
                {
                    _makeDao = new MakeDao();
                    return _makeDao;
                }
                else
                {
                    return _makeDao;
                }
            }
        }


        public MakeResult Create(MakeParam param)
        {

            Data.Entity.Make entity = _makeParamConverter.Convert(param, null);

            _makeDao.Save(entity);

            return _makeResultConverter.Convert(entity);
        }

        public List<MakeResult> Create(List<MakeParam> param)
        {
            List<Data.Entity.Make> entities = new List<Data.Entity.Make>();
            foreach (var item in param)
            {
                entities.Add(_makeParamConverter.Convert(item, null));
            }
            _makeDao.Save(entities);
            List<MakeResult> result = new List<MakeResult>();
            foreach (var item in entities)
            {
                result.Add(_makeResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _makeDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Make> entity = new List<Data.Entity.Make>();
            foreach (var id in idList)
            {
                entity.Add(_makeDao.Find(id));
            }
            foreach (var id in idList)
            {
                _makeDao.Delete(id);
            }
        }

        public MakeResult Find(long id)
        {
            try
            {
                Data.Entity.Make entity = _makeDao.Find(id);
                MakeResult result = _makeResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<MakeResult> Find()
        {
            List<Data.Entity.Make> Makes = _makeDao.Find();
            List<MakeResult> results = new List<MakeResult>();
            foreach (var item in Makes)
            {
                results.Add(_makeResultConverter.Convert(item));
            }
            return results;
        }

        public List<MakeResult> FindByField(string field, string value)
        {
            List<Data.Entity.Make> Makes = _makeDao.FindByField(field, value);
            List<MakeResult> results = new List<MakeResult>();
            foreach (var item in Makes)
            {
                results.Add(_makeResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, MakeParam param)
        {
            Data.Entity.Make oldEntity = _makeDao.Find(id);
            Data.Entity.Make newEntity = _makeParamConverter.Convert(param, oldEntity);
            _makeDao.Update(newEntity);
        }

        public void Update(List<MakeParam> param)
        {
            List<Data.Entity.Make> entity = new List<Data.Entity.Make>();
            foreach (var item in param)
            {
                Data.Entity.Make oldEntity = _makeDao.Find(item.Id);
                Data.Entity.Make newEntity = _makeParamConverter.Convert(item, oldEntity);
                _makeDao.Update(newEntity);
            }
        }
    }
}
