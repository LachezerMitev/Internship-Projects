using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.CheckUpStatus
{
    class CheckUpStatusDao : ICheckUpStatusDao
    {
        public void Delete(long id)
        {
            Data.Entity.CheckUpStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.CheckUpStatus entity)
        {
            CheckUpStatusStorage.CheckUpStatusList.Remove(entity);
            CheckUpStatusStorage.CheckUpStatusDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.CheckUpStatus> Find()
        {
            return CheckUpStatusStorage.CheckUpStatusList;
        }

        public Data.Entity.CheckUpStatus Find(long id)
        {
            return CheckUpStatusStorage.CheckUpStatusList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public List<Data.Entity.CheckUpStatus> FindByField(string field, string value)
        {
            return CheckUpStatusStorage.CheckUpStatusList.Where
                (account => account.GetType().GetProperty(field).GetValue(account, null).ToString().Equals(value)).ToList();
        }

        public Data.Entity.CheckUpStatus Save(Data.Entity.CheckUpStatus entity)
        {

            CheckUpStatusStorage.CheckUpStatusList.Add(entity);
            CheckUpStatusStorage.CheckUpStatusDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.CheckUpStatus> Save(List<Data.Entity.CheckUpStatus> entity)
        {
            entity.ForEach(x => CheckUpStatusStorage.CheckUpStatusList.Add(x));

            entity.ForEach(x => CheckUpStatusStorage.CheckUpStatusDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.CheckUpStatus Update(Data.Entity.CheckUpStatus entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.CheckUpStatus> Update(List<Data.Entity.CheckUpStatus> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
