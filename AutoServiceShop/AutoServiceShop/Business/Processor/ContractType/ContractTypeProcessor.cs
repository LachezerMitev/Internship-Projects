using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.ContractType;
using AutoServiceShop.Business.Processor.Converter.ContractType;

namespace AutoServiceShop.Business.Processor.ContractType
{
    class ContractTypeProcessor : IContractTypeProcessor
    {
        private IContractTypeParamConverter _contractTypeParamConverter;
        public IContractTypeParamConverter ContractTypeParamConverter
        {
            set => _contractTypeParamConverter = value;
            get
            {
                if (_contractTypeParamConverter == null)
                {
                    _contractTypeParamConverter = new ContractTypeParamConverter();
                    return _contractTypeParamConverter;
                }
                else
                {
                    return _contractTypeParamConverter;
                }
            }
        }

        private IContractTypeResultConverter _contractTypeResultConverter;
        public IContractTypeResultConverter ContractTypeResultConverter
        {
            set => _contractTypeResultConverter = value;
            get
            {
                if (_contractTypeResultConverter == null)
                {
                    _contractTypeResultConverter = new ContractTypeResultConverter();
                    return _contractTypeResultConverter;
                }
                else
                {
                    return _contractTypeResultConverter;
                }
            }
        }

        private IContractTypeDao _contractTypeDao;
        public IContractTypeDao ContractTypeDataObject
        {
            set => _contractTypeDao = value;
            get
            {
                if (_contractTypeDao == null)
                {
                    _contractTypeDao = new ContractTypeDao();
                    return _contractTypeDao;
                }
                else
                {
                    return _contractTypeDao;
                }
            }
        }


        public ContractTypeResult Create(ContractTypeParam param)
        {

            Data.Entity.ContractType entity = _contractTypeParamConverter.Convert(param, null);

            _contractTypeDao.Save(entity);

            return _contractTypeResultConverter.Convert(entity);
        }

        public List<ContractTypeResult> Create(List<ContractTypeParam> param)
        {
            List<Data.Entity.ContractType> entities = new List<Data.Entity.ContractType>();
            foreach (var item in param)
            {
                entities.Add(_contractTypeParamConverter.Convert(item, null));
            }
            _contractTypeDao.Save(entities);
            List<ContractTypeResult> result = new List<ContractTypeResult>();
            foreach (var item in entities)
            {
                result.Add(_contractTypeResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _contractTypeDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.ContractType> entity = new List<Data.Entity.ContractType>();
            foreach (var id in idList)
            {
                entity.Add(_contractTypeDao.Find(id));
            }
            foreach (var id in idList)
            {
                _contractTypeDao.Delete(id);
            }
        }

        public ContractTypeResult Find(long id)
        {
            try
            {
                Data.Entity.ContractType entity = _contractTypeDao.Find(id);
                ContractTypeResult result = _contractTypeResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<ContractTypeResult> Find()
        {
            List<Data.Entity.ContractType> ContractTypes = _contractTypeDao.Find();
            List<ContractTypeResult> results = new List<ContractTypeResult>();
            foreach (var item in ContractTypes)
            {
                results.Add(_contractTypeResultConverter.Convert(item));
            }
            return results;
        }

        public List<ContractTypeResult> FindByField(string field, string value)
        {
            List<Data.Entity.ContractType> ContractTypes = _contractTypeDao.FindByField(field, value);
            List<ContractTypeResult> results = new List<ContractTypeResult>();
            foreach (var item in ContractTypes)
            {
                results.Add(_contractTypeResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, ContractTypeParam param)
        {
            Data.Entity.ContractType oldEntity = _contractTypeDao.Find(id);
            Data.Entity.ContractType newEntity = _contractTypeParamConverter.Convert(param, oldEntity);
            _contractTypeDao.Update(newEntity);
        }

        public void Update(List<ContractTypeParam> param)
        {
            List<Data.Entity.ContractType> entity = new List<Data.Entity.ContractType>();
            foreach (var item in param)
            {
                Data.Entity.ContractType oldEntity = _contractTypeDao.Find(item.Id);
                Data.Entity.ContractType newEntity = _contractTypeParamConverter.Convert(item, oldEntity);
                _contractTypeDao.Update(newEntity);
            }
        }
    }
}
