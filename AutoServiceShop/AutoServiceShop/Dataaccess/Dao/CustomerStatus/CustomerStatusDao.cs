using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.CustomerStatus
{
    class CustomerStatusDao : ICustomerStatusDao
    {
        public void Delete(long id)
        {
            Data.Entity.CustomerStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.CustomerStatus entity)
        {
            CustomerStatusStorage.CustomerStatusList.Remove(entity);
            CustomerStatusStorage.CustomerStatusDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.CustomerStatus> Find()
        {
            return CustomerStatusStorage.CustomerStatusList;
        }

        public Data.Entity.CustomerStatus Find(long id)
        {
            return CustomerStatusStorage.CustomerStatusList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public Data.Entity.CustomerStatus Save(Data.Entity.CustomerStatus entity)
        {

            CustomerStatusStorage.CustomerStatusList.Add(entity);
            CustomerStatusStorage.CustomerStatusDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.CustomerStatus> Save(List<Data.Entity.CustomerStatus> entity)
        {
            entity.ForEach(x => CustomerStatusStorage.CustomerStatusList.Add(x));

            entity.ForEach(x => CustomerStatusStorage.CustomerStatusDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.CustomerStatus Update(Data.Entity.CustomerStatus entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.CustomerStatus> Update(List<Data.Entity.CustomerStatus> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
