using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.AccountStatus
{
    class AccountStatusDao : IAccountStatusDao
    {
        public void Delete(long id)
        {
            Data.Entity.AccountStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.AccountStatus entity)
        {
            AccountStatusStorage.AccountStatusList.Remove(entity);
            AccountStatusStorage.AccountStatusDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.AccountStatus> Find()
        {
            return AccountStatusStorage.AccountStatusList;
        }

        public Data.Entity.AccountStatus Find(long id)
        {
            return AccountStatusStorage.AccountStatusList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public List<Data.Entity.AccountStatus> FindByField(string field, string value)
        {
            return AccountStatusStorage.AccountStatusList.Where
                (account => account.GetType().GetProperty(field).GetValue(account, null).ToString().Equals(value)).ToList();
        }

        public Data.Entity.AccountStatus Save(Data.Entity.AccountStatus entity)
        {
            AccountStatusStorage.AccountStatusList.Add(entity);
            AccountStatusStorage.AccountStatusDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.AccountStatus> Save(List<Data.Entity.AccountStatus> entity)
        {
            entity.ForEach(x => AccountStatusStorage.AccountStatusList.Add(x));

            entity.ForEach(x => AccountStatusStorage.AccountStatusDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.AccountStatus Update(Data.Entity.AccountStatus entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.AccountStatus> Update(List<Data.Entity.AccountStatus> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
