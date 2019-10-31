using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.ContractStatus
{
    class ContractStatusDao : IContractStatusDao
    {
        public void Delete(long id)
        {
            Data.Entity.ContractStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.ContractStatus entity)
        {
            ContractStatusStorage.ContractStatusList.Remove(entity);
            ContractStatusStorage.ContractStatusDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.ContractStatus> Find()
        {
            return ContractStatusStorage.ContractStatusList;
        }

        public Data.Entity.ContractStatus Find(long id)
        {
            return ContractStatusStorage.ContractStatusList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public Data.Entity.ContractStatus Save(Data.Entity.ContractStatus entity)
        {

            ContractStatusStorage.ContractStatusList.Add(entity);
            ContractStatusStorage.ContractStatusDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.ContractStatus> Save(List<Data.Entity.ContractStatus> entity)
        {
            entity.ForEach(x => ContractStatusStorage.ContractStatusList.Add(x));

            entity.ForEach(x => ContractStatusStorage.ContractStatusDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.ContractStatus Update(Data.Entity.ContractStatus entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.ContractStatus> Update(List<Data.Entity.ContractStatus> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
