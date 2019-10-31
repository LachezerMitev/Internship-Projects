using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.ContractType
{
    class ContractTypeDao : IContractTypeDao
    {
        public void Delete(long id)
        {
            Data.Entity.ContractType entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.ContractType entity)
        {
            ContractTypeStorage.ContractTypeList.Remove(entity);
            ContractTypeStorage.ContractTypeDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.ContractType> Find()
        {
            return ContractTypeStorage.ContractTypeList;
        }

        public Data.Entity.ContractType Find(long id)
        {
            return ContractTypeStorage.ContractTypeList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public Data.Entity.ContractType Save(Data.Entity.ContractType entity)
        {

            ContractTypeStorage.ContractTypeList.Add(entity);
            ContractTypeStorage.ContractTypeDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.ContractType> Save(List<Data.Entity.ContractType> entity)
        {
            entity.ForEach(x => ContractTypeStorage.ContractTypeList.Add(x));

            entity.ForEach(x => ContractTypeStorage.ContractTypeDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.ContractType Update(Data.Entity.ContractType entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.ContractType> Update(List<Data.Entity.ContractType> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
