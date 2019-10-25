using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.Contract
{
    class ContractDao : IContractDao
    {
        public void Delete(long id)
        {
            Data.Entity.Contract entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.Contract entity)
        {
            ContractStorage.ContractList.Remove(entity);
            ContractStorage.ContractDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.Contract> Find()
        {
            return ContractStorage.ContractList;
        }

        public Data.Entity.Contract Find(long id)
        {
            return ContractStorage.ContractList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public Data.Entity.Contract Save(Data.Entity.Contract entity)
        {

            ContractStorage.ContractList.Add(entity);
            ContractStorage.ContractDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.Contract> Save(List<Data.Entity.Contract> entity)
        {
            entity.ForEach(x => ContractStorage.ContractList.Add(x));

            entity.ForEach(x => ContractStorage.ContractDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.Contract Update(Data.Entity.Contract entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.Contract> Update(List<Data.Entity.Contract> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
