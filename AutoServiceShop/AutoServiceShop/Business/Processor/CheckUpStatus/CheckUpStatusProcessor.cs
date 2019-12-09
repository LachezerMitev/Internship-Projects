using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;

namespace AutoServiceShop.Business.Processor.CheckUpStatus
{
    class CheckUpStatusProcessor : ICheckUpStatusProcessor
    {
        private ICheckUpStatusParamConverter _checkUpStatusParamConverter;
        public ICheckUpStatusParamConverter CheckUpStatusParamConverter
        {
            set => _checkUpStatusParamConverter = value;
            get
            {
                if (_checkUpStatusParamConverter == null)
                {
                    _checkUpStatusParamConverter = new CheckUpStatusParamConverter();
                    return _checkUpStatusParamConverter;
                }
                else
                {
                    return _checkUpStatusParamConverter;
                }
            }
        }

        private ICheckUpStatusResultConverter _checkUpStatusResultConverter;
        public ICheckUpStatusResultConverter CheckUpStatusResultConverter
        {
            set => _checkUpStatusResultConverter = value;
            get
            {
                if (_checkUpStatusResultConverter == null)
                {
                    _checkUpStatusResultConverter = new CheckUpStatusResultConverter();
                    return _checkUpStatusResultConverter;
                }
                else
                {
                    return _checkUpStatusResultConverter;
                }
            }
        }

        private ICheckUpStatusDao _checkUpStatusDao;
        public ICheckUpStatusDao CheckUpStatusDataObject
        {
            set => _checkUpStatusDao = value;
            get
            {
                if (_checkUpStatusDao == null)
                {
                    _checkUpStatusDao = new CheckUpStatusDao();
                    return _checkUpStatusDao;
                }
                else
                {
                    return _checkUpStatusDao;
                }
            }
        }


        public CheckUpStatusResult Create(CheckUpStatusParam param)
        {

            Data.Entity.CheckUpStatus entity = _checkUpStatusParamConverter.Convert(param, null);

            _checkUpStatusDao.Save(entity);

            return _checkUpStatusResultConverter.Convert(entity);
        }

        public List<CheckUpStatusResult> Create(List<CheckUpStatusParam> param)
        {
            List<Data.Entity.CheckUpStatus> entities = new List<Data.Entity.CheckUpStatus>();
            foreach (var item in param)
            {
                entities.Add(_checkUpStatusParamConverter.Convert(item, null));
            }
            _checkUpStatusDao.Save(entities);
            List<CheckUpStatusResult> result = new List<CheckUpStatusResult>();
            foreach (var item in entities)
            {
                result.Add(_checkUpStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _checkUpStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.CheckUpStatus> entity = new List<Data.Entity.CheckUpStatus>();
            foreach (var id in idList)
            {
                entity.Add(_checkUpStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                _checkUpStatusDao.Delete(id);
            }
        }

        public CheckUpStatusResult Find(long id)
        {
            try
            {
                Data.Entity.CheckUpStatus entity = _checkUpStatusDao.Find(id);
                CheckUpStatusResult result = _checkUpStatusResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<CheckUpStatusResult> Find()
        {
            List<Data.Entity.CheckUpStatus> CheckUpStatuss = _checkUpStatusDao.Find();
            List<CheckUpStatusResult> results = new List<CheckUpStatusResult>();
            foreach (var item in CheckUpStatuss)
            {
                results.Add(_checkUpStatusResultConverter.Convert(item));
            }
            return results;
        }

        public List<CheckUpStatusResult> FindByField(string field, string value)
        {
            List<Data.Entity.CheckUpStatus> CheckUpStatuss = _checkUpStatusDao.FindByField(field, value);
            List<CheckUpStatusResult> results = new List<CheckUpStatusResult>();
            foreach (var item in CheckUpStatuss)
            {
                results.Add(_checkUpStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, CheckUpStatusParam param)
        {
            Data.Entity.CheckUpStatus oldEntity = _checkUpStatusDao.Find(id);
            Data.Entity.CheckUpStatus newEntity = _checkUpStatusParamConverter.Convert(param, oldEntity);
            _checkUpStatusDao.Update(newEntity);
        }

        public void Update(List<CheckUpStatusParam> param)
        {
            List<Data.Entity.CheckUpStatus> entity = new List<Data.Entity.CheckUpStatus>();
            foreach (var item in param)
            {
                Data.Entity.CheckUpStatus oldEntity = _checkUpStatusDao.Find(item.Id);
                Data.Entity.CheckUpStatus newEntity = _checkUpStatusParamConverter.Convert(item, oldEntity);
                _checkUpStatusDao.Update(newEntity);
            }
        }
    }
}
