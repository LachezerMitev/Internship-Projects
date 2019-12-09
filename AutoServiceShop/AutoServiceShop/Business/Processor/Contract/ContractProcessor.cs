using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Contract;
using AutoServiceShop.Business.Processor.Converter.Contract;

namespace AutoServiceShop.Business.Processor.Contract
{
    class ContractProcessor : IContractProcessor
    {
        private IContractParamconverter _contractParamConverter;
        public IContractParamconverter ContractParamConverter
        {
            set => _contractParamConverter = value;
            get
            {
                if (_contractParamConverter == null)
                {
                    _contractParamConverter = new ContractParamConverter();
                    return _contractParamConverter;
                }
                else
                {
                    return _contractParamConverter;
                }
            }
        }

        private IContractResultConverter _contractResultConverter;
        public IContractResultConverter ContractResultConverter
        {
            set => _contractResultConverter = value;
            get
            {
                if (_contractResultConverter == null)
                {
                    _contractResultConverter = new ContractResultConverter();
                    return _contractResultConverter;
                }
                else
                {
                    return _contractResultConverter;
                }
            }
        }

        private IContractDao _ContractDao;
        public IContractDao ContractDataObject
        {
            set => _ContractDao = value;
            get
            {
                if (_ContractDao == null)
                {
                    _ContractDao = new ContractDao();
                    return _ContractDao;
                }
                else
                {
                    return _ContractDao;
                }
            }
        }


        public ContractResult Create(ContractParam param)
        {

            Data.Entity.Contract entity = _contractParamConverter.Convert(param, null);

            _ContractDao.Save(entity);

            return _contractResultConverter.Convert(entity);
        }

        public List<ContractResult> Create(List<ContractParam> param)
        {
            List<Data.Entity.Contract> entities = new List<Data.Entity.Contract>();
            foreach (var item in param)
            {
                entities.Add(_contractParamConverter.Convert(item, null));
            }
            _ContractDao.Save(entities);
            List<ContractResult> result = new List<ContractResult>();
            foreach (var item in entities)
            {
                result.Add(_contractResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _ContractDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Contract> entity = new List<Data.Entity.Contract>();
            foreach (var id in idList)
            {
                entity.Add(_ContractDao.Find(id));
            }
            foreach (var id in idList)
            {
                _ContractDao.Delete(id);
            }
        }

        public ContractResult Find(long id)
        {
            try
            {
                Data.Entity.Contract entity = _ContractDao.Find(id);
                ContractResult result = _contractResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<ContractResult> Find()
        {
            List<Data.Entity.Contract> Contracts = _ContractDao.Find();
            List<ContractResult> results = new List<ContractResult>();
            foreach (var item in Contracts)
            {
                results.Add(_contractResultConverter.Convert(item));
            }
            return results;
        }

        public List<ContractResult> FindByField(string field, string value)
        {
            List<Data.Entity.Contract> Contracts = _ContractDao.FindByField(field, value);
            List<ContractResult> results = new List<ContractResult>();
            foreach (var item in Contracts)
            {
                results.Add(_contractResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, ContractParam param)
        {
            Data.Entity.Contract oldEntity = _ContractDao.Find(id);
            Data.Entity.Contract newEntity = _contractParamConverter.Convert(param, oldEntity);
            _ContractDao.Update(newEntity);
        }

        public void Update(List<ContractParam> param)
        {
            List<Data.Entity.Contract> entity = new List<Data.Entity.Contract>();
            foreach (var item in param)
            {
                Data.Entity.Contract oldEntity = _ContractDao.Find(item.Id);
                Data.Entity.Contract newEntity = _contractParamConverter.Convert(item, oldEntity);
                _ContractDao.Update(newEntity);
            }
        }
    }
}
