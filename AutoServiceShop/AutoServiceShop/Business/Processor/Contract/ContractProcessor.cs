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
        IContractDao ContractDao = new ContractDao();

        IContractParamconverter ContractParamConverter = new ContractParamConverter();
        IContractResultConverter ContractResultConverter = new ContractResultConverter();

        public ContractResult Create(ContractParam param)
        {
            Data.Entity.Contract entity = ContractParamConverter.Convert(param, null);
            ContractDao.Save(entity);

            return ContractResultConverter.Convert(entity);
        }

        public List<ContractResult> Create(List<ContractParam> param)
        {
            List<Data.Entity.Contract> entities = new List<Data.Entity.Contract>();
            foreach (var item in param)
            {
                entities.Add(ContractParamConverter.Convert(item, null));
            }
            ContractDao.Save(entities);
            List<ContractResult> result = new List<ContractResult>();
            foreach (var item in entities)
            {
                result.Add(ContractResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            ContractDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Contract> entity = new List<Data.Entity.Contract>();
            foreach (var id in idList)
            {
                entity.Add(ContractDao.Find(id));
            }
            foreach (var id in idList)
            {
                ContractDao.Delete(id);
            }
        }

        public ContractResult Find(long id)
        {
            Data.Entity.Contract entity = ContractDao.Find(id);
            ContractResult result = ContractResultConverter.Convert(entity);
            return result;
        }

        public List<ContractResult> Find()
        {
            List<Data.Entity.Contract> entity = ContractDao.Find();
            List<ContractResult> results = new List<ContractResult>();
            foreach (var item in entity)
            {
                results.Add(ContractResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, ContractParam param)
        {
            Data.Entity.Contract oldEntity = ContractDao.Find(id);
            Data.Entity.Contract newEntity = ContractParamConverter.Convert(param, null);
            ContractDao.Update(newEntity);
        }

        public void Update(List<ContractParam> param)
        {
            List<Data.Entity.Contract> entity = new List<Data.Entity.Contract>();
            foreach (var item in param)
            {
                Data.Entity.Contract oldEntity = ContractDao.Find(item.Id);
                Data.Entity.Contract newEntity = ContractParamConverter.Convert(item, null);
                ContractDao.Update(newEntity);
            }
        }
    }
}
