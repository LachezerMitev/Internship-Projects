using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.CheckUp;
using AutoServiceShop.Business.Processor.Converter.CheckUp;

namespace AutoServiceShop.Business.Processor.CheckUp
{
    class CheckUpProcessor : ICheckUpProcessor
    {
        private ICheckUpParamConverter _checkUpParamConverter;
        public ICheckUpParamConverter CheckUpParamConverter
        {
            set => _checkUpParamConverter = value;
            get
            {
                if (_checkUpParamConverter == null)
                {
                    _checkUpParamConverter = new CheckUpParamConverter();
                    return _checkUpParamConverter;
                }
                else
                {
                    return _checkUpParamConverter;
                }
            }
        }

        private ICheckUpResultConverter _checkUpResultConverter;
        public ICheckUpResultConverter CheckUpResultConverter
        {
            set => _checkUpResultConverter = value;
            get
            {
                if (_checkUpResultConverter == null)
                {
                    _checkUpResultConverter = new CheckUpResultConverter();
                    return _checkUpResultConverter;
                }
                else
                {
                    return _checkUpResultConverter;
                }
            }
        }

        private ICheckUpDao _checkUpDao;
        public ICheckUpDao CheckUpDataObject
        {
            set => _checkUpDao = value;
            get
            {
                if (_checkUpDao == null)
                {
                    _checkUpDao = new CheckUpDao();
                    return _checkUpDao;
                }
                else
                {
                    return _checkUpDao;
                }
            }
        }


        public CheckUpResult Create(CheckUpParam param)
        {

            Data.Entity.CheckUp entity = _checkUpParamConverter.Convert(param, null);

            _checkUpDao.Save(entity);

            return _checkUpResultConverter.Convert(entity);
        }

        public List<CheckUpResult> Create(List<CheckUpParam> param)
        {
            List<Data.Entity.CheckUp> entities = new List<Data.Entity.CheckUp>();
            foreach (var item in param)
            {
                entities.Add(_checkUpParamConverter.Convert(item, null));
            }
            _checkUpDao.Save(entities);
            List<CheckUpResult> result = new List<CheckUpResult>();
            foreach (var item in entities)
            {
                result.Add(_checkUpResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _checkUpDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.CheckUp> entity = new List<Data.Entity.CheckUp>();
            foreach (var id in idList)
            {
                entity.Add(_checkUpDao.Find(id));
            }
            foreach (var id in idList)
            {
                _checkUpDao.Delete(id);
            }
        }

        public CheckUpResult Find(long id)
        {
            try
            {
                Data.Entity.CheckUp entity = _checkUpDao.Find(id);
                CheckUpResult result = _checkUpResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<CheckUpResult> Find()
        {
            List<Data.Entity.CheckUp> CheckUps = _checkUpDao.Find();
            List<CheckUpResult> results = new List<CheckUpResult>();
            foreach (var item in CheckUps)
            {
                results.Add(_checkUpResultConverter.Convert(item));
            }
            return results;
        }

        public List<CheckUpResult> FindByField(string field, string value)
        {
            List<Data.Entity.CheckUp> CheckUps = _checkUpDao.FindByField(field, value);
            List<CheckUpResult> results = new List<CheckUpResult>();
            foreach (var item in CheckUps)
            {
                results.Add(_checkUpResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, CheckUpParam param)
        {
            Data.Entity.CheckUp oldEntity = _checkUpDao.Find(id);
            Data.Entity.CheckUp newEntity = _checkUpParamConverter.Convert(param, oldEntity);
            _checkUpDao.Update(newEntity);
        }

        public void Update(List<CheckUpParam> param)
        {
            List<Data.Entity.CheckUp> entity = new List<Data.Entity.CheckUp>();
            foreach (var item in param)
            {
                Data.Entity.CheckUp oldEntity = _checkUpDao.Find(item.Id);
                Data.Entity.CheckUp newEntity = _checkUpParamConverter.Convert(item, oldEntity);
                _checkUpDao.Update(newEntity);
            }
        }
    }
}
