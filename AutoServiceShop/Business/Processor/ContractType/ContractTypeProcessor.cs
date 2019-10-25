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
        IContractTypeDao ContractTypeDao = new ContractTypeDao();

        IContractTypeParamConverter ContractTypeParamConverter = new ContractTypeParamConverter();
        IContractTypeResultConverter ContractTypeResultConverter = new ContractTypeResultConverter();

        public ContractTypeResult Create(ContractTypeParam param)
        {

            Data.Entity.ContractType entity = ContractTypeParamConverter.Convert(param);
            ContractTypeDao.Save(entity);

            return ContractTypeResultConverter.Convert(entity);
        }

        public List<ContractTypeResult> Create(List<ContractTypeParam> param)
        {
            List<Data.Entity.ContractType> entities = new List<Data.Entity.ContractType>();
            foreach (var item in param)
            {
                entities.Add(ContractTypeParamConverter.Convert(item));
            }
            ContractTypeDao.Save(entities);
            List<ContractTypeResult> result = new List<ContractTypeResult>();
            foreach (var item in entities)
            {
                result.Add(ContractTypeResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            ContractTypeDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.ContractType> entity = new List<Data.Entity.ContractType>();
            foreach (var id in idList)
            {
                entity.Add(ContractTypeDao.Find(id));
            }
            foreach (var id in idList)
            {
                ContractTypeDao.Delete(id);
            }
        }

        public ContractTypeResult Find(long id)
        {
            Data.Entity.ContractType entity = ContractTypeDao.Find(id);
            ContractTypeResult result = ContractTypeResultConverter.Convert(entity);
            return result;
        }

        public List<ContractTypeResult> Find()
        {
            List<Data.Entity.ContractType> accounts = ContractTypeDao.Find();
            List<ContractTypeResult> results = new List<ContractTypeResult>();
            foreach (var item in accounts)
            {
                results.Add(ContractTypeResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, ContractTypeParam param)
        {
            Data.Entity.ContractType oldEntity = ContractTypeDao.Find(id);
            Data.Entity.ContractType newEntity = ContractTypeParamConverter.Convert(param);
            ContractTypeDao.Update(newEntity);
        }

        public void Update(List<ContractTypeParam> param)
        {
            List<Data.Entity.ContractType> entity = new List<Data.Entity.ContractType>();
            foreach (var item in param)
            {
                Data.Entity.ContractType oldEntity = ContractTypeDao.Find(item.Id);
                Data.Entity.ContractType newEntity = ContractTypeParamConverter.Convert(item);
                ContractTypeDao.Update(newEntity);
            }
        }
    }
}
