using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.AutoPartStatus
{
    class AutoPartStatusDao : IAutoPartStatusDao
    {
        public void Delete(long id)
        {
            Data.Entity.AutoPartStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.AutoPartStatus entity)
        {
            AutoPartStatusStorage.AutoPartStatusList.Remove(entity);
            AutoPartStatusStorage.AutoPartStatusDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.AutoPartStatus> Find()
        {
            return AutoPartStatusStorage.AutoPartStatusList;
        }

        public Data.Entity.AutoPartStatus Find(long id)
        {
            return AutoPartStatusStorage.AutoPartStatusList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public List<Data.Entity.AutoPartStatus> FindByField(string field, string value)
        {
            return AutoPartStatusStorage.AutoPartStatusList.Where
                (account => account.GetType().GetProperty(field).GetValue(account, null).ToString().Equals(value)).ToList();
        }

        public Data.Entity.AutoPartStatus Save(Data.Entity.AutoPartStatus entity)
        {

            AutoPartStatusStorage.AutoPartStatusList.Add(entity);
            AutoPartStatusStorage.AutoPartStatusDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.AutoPartStatus> Save(List<Data.Entity.AutoPartStatus> entity)
        {
            entity.ForEach(x => AutoPartStatusStorage.AutoPartStatusList.Add(x));

            entity.ForEach(x => AutoPartStatusStorage.AutoPartStatusDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.AutoPartStatus Update(Data.Entity.AutoPartStatus entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.AutoPartStatus> Update(List<Data.Entity.AutoPartStatus> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
