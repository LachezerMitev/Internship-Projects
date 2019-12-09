using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;

namespace AutoServiceShop.Business.Processor.ContractStatus
{
    class ContractStatusProcessor : IContractStatusProcessor
    {
        private IContractStatusParamConverter _contractStatusParamConverter;
        public IContractStatusParamConverter ContractStatusParamConverter
        {
            set => _contractStatusParamConverter = value;
            get
            {
                if (_contractStatusParamConverter == null)
                {
                    _contractStatusParamConverter = new ContractStatusParamConverter();
                    return _contractStatusParamConverter;
                }
                else
                {
                    return _contractStatusParamConverter;
                }
            }
        }

        private IContractStatusResultConverter _contractStatusResultConverter;
        public IContractStatusResultConverter ContractStatusResultConverter
        {
            set => _contractStatusResultConverter = value;
            get
            {
                if (_contractStatusResultConverter == null)
                {
                    _contractStatusResultConverter = new ContractStatusResultConverter();
                    return _contractStatusResultConverter;
                }
                else
                {
                    return _contractStatusResultConverter;
                }
            }
        }

        private IContractStatusDao _contractStatusDao;
        public IContractStatusDao ContractStatusDataObject
        {
            set => _contractStatusDao = value;
            get
            {
                if (_contractStatusDao == null)
                {
                    _contractStatusDao = new ContractStatusDao();
                    return _contractStatusDao;
                }
                else
                {
                    return _contractStatusDao;
                }
            }
        }


        public ContractStatusResult Create(ContractStatusParam param)
        {

            Data.Entity.ContractStatus entity = _contractStatusParamConverter.Convert(param, null);

            _contractStatusDao.Save(entity);

            return _contractStatusResultConverter.Convert(entity);
        }

        public List<ContractStatusResult> Create(List<ContractStatusParam> param)
        {
            List<Data.Entity.ContractStatus> entities = new List<Data.Entity.ContractStatus>();
            foreach (var item in param)
            {
                entities.Add(_contractStatusParamConverter.Convert(item, null));
            }
            _contractStatusDao.Save(entities);
            List<ContractStatusResult> result = new List<ContractStatusResult>();
            foreach (var item in entities)
            {
                result.Add(_contractStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _contractStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.ContractStatus> entity = new List<Data.Entity.ContractStatus>();
            foreach (var id in idList)
            {
                entity.Add(_contractStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                _contractStatusDao.Delete(id);
            }
        }

        public ContractStatusResult Find(long id)
        {
            try
            {
                Data.Entity.ContractStatus entity = _contractStatusDao.Find(id);
                ContractStatusResult result = _contractStatusResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<ContractStatusResult> Find()
        {
            List<Data.Entity.ContractStatus> ContractStatuss = _contractStatusDao.Find();
            List<ContractStatusResult> results = new List<ContractStatusResult>();
            foreach (var item in ContractStatuss)
            {
                results.Add(_contractStatusResultConverter.Convert(item));
            }
            return results;
        }

        public List<ContractStatusResult> FindByField(string field, string value)
        {
            List<Data.Entity.ContractStatus> ContractStatuss = _contractStatusDao.FindByField(field, value);
            List<ContractStatusResult> results = new List<ContractStatusResult>();
            foreach (var item in ContractStatuss)
            {
                results.Add(_contractStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, ContractStatusParam param)
        {
            Data.Entity.ContractStatus oldEntity = _contractStatusDao.Find(id);
            Data.Entity.ContractStatus newEntity = _contractStatusParamConverter.Convert(param, oldEntity);
            _contractStatusDao.Update(newEntity);
        }

        public void Update(List<ContractStatusParam> param)
        {
            List<Data.Entity.ContractStatus> entity = new List<Data.Entity.ContractStatus>();
            foreach (var item in param)
            {
                Data.Entity.ContractStatus oldEntity = _contractStatusDao.Find(item.Id);
                Data.Entity.ContractStatus newEntity = _contractStatusParamConverter.Convert(item, oldEntity);
                _contractStatusDao.Update(newEntity);
            }
        }
    }
}
