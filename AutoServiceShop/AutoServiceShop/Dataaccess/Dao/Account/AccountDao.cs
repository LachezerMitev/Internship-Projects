using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.Account
{
    class AccountDao : IAccountDao
    {
        public void Delete(long id)
        {
            Data.Entity.Account entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.Account entity)
        {
            AccountStorage.AccountList.Remove(entity);
            AccountStorage.AccountDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.Account> Find()
        {
            return AccountStorage.AccountList;
        }

        public Data.Entity.Account Find(long id)
        {
            return AccountStorage.AccountList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public List<Data.Entity.Account> FindByField(string field, string value)
        {
            return AccountStorage.AccountList.Where
                (account => account.GetType().GetProperty(field).GetValue(account, null).ToString().Equals(value)).ToList();
        }

        public Data.Entity.Account Save(Data.Entity.Account entity)
        {

            AccountStorage.AccountList.Add(entity);
            AccountStorage.AccountDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.Account> Save(List<Data.Entity.Account> entity)
        {
            entity.ForEach(x => AccountStorage.AccountList.Add(x));

            entity.ForEach(x => AccountStorage.AccountDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.Account Update(Data.Entity.Account entity)
        {
            Delete(entity.Id);
            Save(entity);  
            return entity;
        }

        public List<Data.Entity.Account> Update(List<Data.Entity.Account> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
