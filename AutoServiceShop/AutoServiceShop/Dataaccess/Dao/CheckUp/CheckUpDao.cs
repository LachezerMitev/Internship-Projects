using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.CheckUp
{
    class CheckUpDao : ICheckUpDao
    {
        public void Delete(long id)
        {
            Data.Entity.CheckUp entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.CheckUp entity)
        {
            CheckUpStorage.CheckUpList.Remove(entity);
            CheckUpStorage.CheckUpDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.CheckUp> Find()
        {
            return CheckUpStorage.CheckUpList;
        }

        public Data.Entity.CheckUp Find(long id)
        {
            return CheckUpStorage.CheckUpList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public Data.Entity.CheckUp Save(Data.Entity.CheckUp entity)
        {

            CheckUpStorage.CheckUpList.Add(entity);
            CheckUpStorage.CheckUpDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.CheckUp> Save(List<Data.Entity.CheckUp> entity)
        {
            entity.ForEach(x => CheckUpStorage.CheckUpList.Add(x));

            entity.ForEach(x => CheckUpStorage.CheckUpDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.CheckUp Update(Data.Entity.CheckUp entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.CheckUp> Update(List<Data.Entity.CheckUp> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
